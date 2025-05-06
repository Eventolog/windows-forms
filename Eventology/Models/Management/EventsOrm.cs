using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

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

        public static bool DeleteEventById(int id)
        {
            try
            {
                var ev = Orm.db.events.Find(id);
                if (ev != null)
                {
                    Orm.db.events.Remove(ev);
                    Orm.db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error eliminant esdeveniment: " + ex.Message);
            }
            return false;
        }
    }
}