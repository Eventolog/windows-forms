using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eventology.Models.Management
{
    /// <summary>
    /// Contains methods to interact with the Rooms table in the database.
    /// </summary>
    public static class RoomsOrm
    {
        /// <summary>
        /// Selects all rooms from the database.
        /// </summary>
        /// <returns>A list of rooms with their id and name.</returns>
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
                Console.WriteLine("Error general: " + ex.Message);
            }

            return new List<object>();
        }

        /// <summary>
        /// Inserts a new room into the database.
        /// </summary>
        /// <param name="room">The room to insert.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public static bool InsertRoom(Models.rooms room)
        {
            try
            {
                // Add the new room to the database
                Orm.db.rooms.Add(room);

                // Save the changes to the database
                Orm.db.SaveChanges();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + Orm.ErrorMessage(ex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Updates an existing room in the database.
        /// </summary>
        /// <param name="room">The room to update with its new data.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public static bool UpdateRoom(Models.rooms room)
        {
            try
            {
                // Find the existing room by ID
                var existingRoom = Orm.db.rooms.Find(room.id);
                if (existingRoom != null)
                {
                    // Update the room properties
                    existingRoom.name = room.name;

                    // Save the changes to the database
                    Orm.db.SaveChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine("Room not found.");
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + Orm.ErrorMessage(ex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Deletes a room from the database by its id.
        /// </summary>
        /// <param name="id">The id of the room to delete.</param>
        /// <returns>True if the room was successfully deleted; otherwise, false.</returns>
        public static bool DeleteRoomById(int id)
        {
            try
            {
                var room = Orm.db.rooms.Find(id);
                if (room != null)
                {
                    Orm.db.rooms.Remove(room);
                    Orm.db.SaveChanges();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + Orm.ErrorMessage(ex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return false;
        }
    }
}
