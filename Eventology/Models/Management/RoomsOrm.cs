using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eventology.Models.Management
{
    /// <summary>
    /// Provides operations to manage and query room-related data from the database.
    /// </summary>
    public static class RoomsOrm
    {
        /// <summary>
        /// Represents statistics about room availability.
        /// </summary>
        public class RoomStats
        {
            /// <summary>
            /// Number of available (unoccupied) rooms.
            /// </summary>
            public int Available { get; set; }

            /// <summary>
            /// Number of currently occupied rooms.
            /// </summary>
            public int Occupied { get; set; }
        }

        /// <summary>
        /// Retrieves the count of available and occupied rooms.
        /// </summary>
        /// <returns>A <see cref="RoomStats"/> object with availability details.</returns>
        public static RoomStats GetRoomAvailability()
        {
            try
            {
                int total = Orm.db.rooms.Count();
                int occupied = Orm.db.events
                    .Where(e => e.status == "active")
                    .Select(e => e.room_id)
                    .Distinct()
                    .Count();
                int available = total - occupied;

                return new RoomStats
                {
                    Available = available,
                    Occupied = occupied
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error obtaining room availability: " + ex.Message);
                return new RoomStats { Available = 0, Occupied = 0 };
            }
        }

        /// <summary>
        /// Retrieves all rooms from the database.
        /// </summary>
        /// <returns>A list of anonymous objects containing room IDs and names.</returns>
        public static List<object> SelectAllRooms()
        {
            try
            {
                return Orm.db.rooms
                    .Select(r => new
                    {
                        r.id,
                        r.name
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
    }
}