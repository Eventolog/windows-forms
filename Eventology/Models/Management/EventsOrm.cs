using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Eventology.Models.Management
{
    public static class EventsOrm
    {
        public static List<object> SelectAllEvents()
        {
            try
            {
                return Orm.db.events
                    .Select(ev => new
                    {
                        ev.id,
                        ev.name,
                        ev.start_time,
                        ev.end_time,
                        ev.status
                    })
                    .ToList<object>();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(Orm.ErrorMessage(ex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return new List<object>();
        }

        public static bool AddEvent(events newEvent)
        {
            try
            {
                Orm.db.events.Add(newEvent);
                Orm.db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error afegint esdeveniment: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteEventById(int eventId)
        {
            try
            {
                var ev = Orm.db.events.FirstOrDefault(e => e.id == eventId);
                if (ev == null) return false;

                // Eliminar dependències explícitament
                Orm.db.tickets.RemoveRange(ev.tickets);
                Orm.db.media.RemoveRange(ev.media);

                Orm.db.events.Remove(ev);
                Orm.db.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Error eliminant esdeveniment: " + (ex.InnerException?.InnerException?.Message ?? ex.Message));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return false;
        }

        public static bool InsertEvent(Models.events newEvent)
        {
            try
            {
                Orm.db.events.Add(newEvent);
                Orm.db.SaveChanges();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL: " + Orm.ErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static Models.events GetEventById(int eventId)
        {
            try
            {
                return Orm.db.events.FirstOrDefault(ev => ev.id == eventId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en obtenir esdeveniment: " + ex.Message);
                return null;
            }
        }

        public static bool UpdateEvent(int eventId, string name, string description, DateTime start, DateTime end, string status, int organizerId, int roomId)
        {
            try
            {
                var ev = Orm.db.events.FirstOrDefault(e => e.id == eventId);
                if (ev == null)
                    return false;

                ev.name = name;
                ev.description = description;
                ev.start_time = start;
                ev.end_time = end;
                ev.status = status;
                ev.organizer_id = organizerId;
                ev.room_id = roomId;

                Orm.db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en actualitzar esdeveniment: " + ex.Message);
                return false;
            }
        }
    }
}