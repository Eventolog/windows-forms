using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eventology.Models.Management
{
    public static class RoomsOrm
    {
        public class RoomStats
        {
            public int Available { get; set; }
            public int Occupied { get; set; }
        }

        public static RoomStats GetRoomAvailability()
        {
            try
            {
                int total = Orm.db.rooms.Count();
                int occupied = Orm.db.events.Where(e => e.status == "active").Select(e => e.room_id).Distinct().Count();
                int available = total - occupied;

                return new RoomStats
                {
                    Available = available,
                    Occupied = occupied
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error obtenint disponibilitat de sales: " + ex.Message);
                return new RoomStats { Available = 0, Occupied = 0 };
            }
        }

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
    }
}