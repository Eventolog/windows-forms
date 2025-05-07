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

        public static List<object> SelectAllUsers()
        {
            try
            {
                return Orm.db.users
                    .Select(u => new { u.id, u.name })
                    .ToList<object>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error carregant usuaris: " + ex.Message);
            }
            return new List<object>();
        }

        public static bool AddUserToEvent(int userId, int eventId)
        {
            try
            {
                var ticket = new tickets
                {
                    name = "Reserva Automàtica",
                    reservation = DateTime.Now,
                    status = "reserved",
                    buyer_id = userId,
                    event_id = eventId
                };
                Orm.db.tickets.Add(ticket);
                Orm.db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error afegint usuari a event: " + ex.Message);
            }
            return false;
        }

        public static List<object> SelectAvailableUsersForEvent(int eventId)
        {
            try
            {
                // IDs d’usuaris ja assignats a l’event
                var assignedUserIds = Orm.db.tickets
                    .Where(t => t.event_id == eventId)
                    .Select(t => t.buyer_id)
                    .Distinct()
                    .ToList();

                // Retornem només els que NO estan assignats
                var users = Orm.db.users
                    .Where(u => !assignedUserIds.Contains(u.id))
                    .Select(u => new
                    {
                        u.id,
                        u.name
                    })
                    .ToList<object>();

                return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error carregant usuaris disponibles: " + ex.Message);
            }

            return new List<object>();
        }
    }
}