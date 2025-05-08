using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Eventology.Models.Management
{
    /// <summary>
    /// Provides operations for managing events in the database.
    /// </summary>
    public static class EventsOrm
    {
        /// <summary>
        /// Retrieves all events with selected properties.
        /// </summary>
        /// <returns>List of objects with event data (id, name, start_time, end_time, status).</returns>
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
                Console.WriteLine("General error: " + ex.Message);
            }

            return new List<object>();
        }

        /// <summary>
        /// Adds a new event to the database.
        /// </summary>
        /// <param name="newEvent">Event object to add.</param>
        /// <returns>True if successful, false otherwise.</returns>
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
                Console.WriteLine("Error adding event: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Deletes an event by its ID, including related tickets and media.
        /// </summary>
        /// <param name="eventId">Event ID.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public static bool DeleteEventById(int eventId)
        {
            try
            {
                var ev = Orm.db.events.FirstOrDefault(e => e.id == eventId);
                if (ev == null) return false;

                // Explicitly remove dependencies
                Orm.db.tickets.RemoveRange(ev.tickets);
                Orm.db.media.RemoveRange(ev.media);

                Orm.db.events.Remove(ev);
                Orm.db.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine("Error deleting event: " + (ex.InnerException?.InnerException?.Message ?? ex.Message));
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Inserts a new event into the database.
        /// </summary>
        /// <param name="newEvent">Event object to insert.</param>
        /// <returns>True if successful, false otherwise.</returns>
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
                MessageBox.Show("SQL error: " + Orm.ErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /// <summary>
        /// Retrieves a specific event by its ID.
        /// </summary>
        /// <param name="eventId">Event ID.</param>
        /// <returns>The event object if found, null otherwise.</returns>
        public static Models.events GetEventById(int eventId)
        {
            try
            {
                return Orm.db.events.FirstOrDefault(ev => ev.id == eventId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving event: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Updates the details of an existing event.
        /// </summary>
        /// <param name="eventId">Event ID.</param>
        /// <param name="name">New name.</param>
        /// <param name="description">New description.</param>
        /// <param name="start">New start time.</param>
        /// <param name="end">New end time.</param>
        /// <param name="status">New status.</param>
        /// <param name="organizerId">Organizer ID.</param>
        /// <param name="roomId">Room ID.</param>
        /// <returns>True if update is successful, false otherwise.</returns>
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
                Console.WriteLine("Error updating event: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Gets the total count of events in the system.
        /// </summary>
        /// <returns>Number of events.</returns>
        public static int GetTotalEvents()
        {
            try
            {
                return Orm.db.events.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting events: " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Retrieves a list of the next upcoming events, limited by the specified number.
        /// </summary>
        /// <param name="top">Maximum number of events to retrieve.</param>
        /// <returns>List of objects with event name, start time, room name, and status.</returns>
        public static List<object> GetUpcomingEvents(int top)
        {
            try
            {
                var now = DateTime.Now;

                var result = (from e in Orm.db.events
                              join r in Orm.db.rooms on e.room_id equals r.id
                              where e.start_time >= now
                              orderby e.start_time
                              select new
                              {
                                  e.name,
                                  e.start_time,
                                  RoomName = r.name,
                                  e.status
                              })
                              .Take(top)
                              .ToList<object>();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving upcoming events: " + ex.Message);
                return new List<object>();
            }
        }
    }
}