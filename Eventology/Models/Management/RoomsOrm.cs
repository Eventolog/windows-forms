using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eventology.Models.Management
{
    public static class RoomsOrm
    {
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