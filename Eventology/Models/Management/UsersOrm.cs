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

        public static bool AddUser(users newUser)
        {
            try
            {
                Orm.db.users.Add(newUser);
                Orm.db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error afegint usuari: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteUserById(int id)
        {
            try
            {
                var user = Orm.db.users.Find(id);
                if (user != null)
                {
                    Orm.db.users.Remove(user);
                    Orm.db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error eliminant usuari: " + ex.Message);
            }
            return false;
        }

        public static bool DeleteUserFromEvent(int userId, int eventId)
        {
            try
            {
                var ticket = Orm.db.tickets
                    .FirstOrDefault(t => t.buyer_id == userId && t.event_id == eventId);

                if (ticket != null)
                {
                    Orm.db.tickets.Remove(ticket);
                    Orm.db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error eliminant la relació usuari-esdeveniment: " + ex.Message);
            }

            return false;
        }

        public static List<object> SelectOrganizers()
        {
            try
            {
                return Orm.db.users
                    .Where(u => u.type == "organizer")
                    .Select(u => new
                    {
                        u.id,
                        u.name
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

        public static users GetUserByCredentials(string username, string password)
        {
            try
            {
                return Orm.db.users.FirstOrDefault(u => u.name == username && u.password == password);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar usuari: " + ex.Message);
                return null;
            }
        }
    }
}