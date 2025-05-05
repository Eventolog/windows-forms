using System;
using System.Linq;
using System.Data.SqlClient;

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
    }
}