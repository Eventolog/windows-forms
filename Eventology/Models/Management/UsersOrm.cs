using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Eventology.Models.Management
{
    public static class UsersOrm
    {
        public static bool ValidateUserLogin(string name, string password)
        {
            try
            {
                return Orm.db.users.Any(u => u.name == name && u.password == password);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(Orm.ErrorMessage(ex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return false;
        }

        public static List<object> SelectUsersByEvent(int eventId)
        {
            try
            {
                return Orm.db.tickets
                    .Where(t => t.event_id == eventId)
                    .Select(t => new
                    {
                        t.users.id,
                        t.users.name,
                        t.users.email,
                        t.users.type
                    })
                    .Distinct()
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