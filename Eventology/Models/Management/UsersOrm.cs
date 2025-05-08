using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Eventology.Models.Management
{
    /// <summary>
    /// Provides operations to manage users and their relationships with events.
    /// </summary>
    public static class UsersOrm
    {
        /// <summary>
        /// Validates user credentials (username and password).
        /// </summary>
        /// <param name="name">Username.</param>
        /// <param name="password">Password.</param>
        /// <returns>True if valid, false otherwise.</returns>
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
                Console.WriteLine("General error: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Gets the total number of users in the system.
        /// </summary>
        /// <returns>Number of users.</returns>
        public static int GetTotalUsers()
        {
            try
            {
                return Orm.db.users.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting users: " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Selects all users assigned to a specific event.
        /// </summary>
        /// <param name="eventId">Event ID.</param>
        /// <returns>List of users linked to the event.</returns>
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
                Console.WriteLine("General error: " + ex.Message);
            }

            return new List<object>();
        }

        /// <summary>
        /// Removes the user-event relationship by deleting the ticket.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="eventId">Event ID.</param>
        /// <returns>True if successful, false otherwise.</returns>
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
                Console.WriteLine("Error removing user-event relationship: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Adds a user to an event by creating a reservation ticket.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="eventId">Event ID.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public static bool AddUserToEvent(int userId, int eventId)
        {
            try
            {
                var ticket = new tickets
                {
                    name = "Automatic Reservation",
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
                Console.WriteLine("Error adding user to event: " + ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Selects all users not yet assigned to a specific event.
        /// </summary>
        /// <param name="eventId">Event ID.</param>
        /// <returns>List of available users.</returns>
        public static List<object> SelectAvailableUsersForEvent(int eventId)
        {
            try
            {
                // IDs of users already assigned to the event
                var assignedUserIds = Orm.db.tickets
                    .Where(t => t.event_id == eventId)
                    .Select(t => t.buyer_id)
                    .Distinct()
                    .ToList();

                // Return users NOT assigned
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
                Console.WriteLine("Error loading available users: " + ex.Message);
            }

            return new List<object>();
        }

        /// <summary>
        /// Inserts a new user into the database.
        /// </summary>
        /// <param name="user">User entity.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public static bool InsertUser(users user)
        {
            try
            {
                Orm.db.users.Add(user);
                Orm.db.SaveChanges();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(Orm.ErrorMessage(ex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Deletes a user by ID.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public static bool DeleteUserById(int userId)
        {
            try
            {
                var user = Orm.db.users.Find(userId);
                if (user != null)
                {
                    Orm.db.users.Remove(user);
                    Orm.db.SaveChanges();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(Orm.ErrorMessage(ex));
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }

            return false;
        }

        /// <summary>
        /// Selects all users with the type "organizer".
        /// </summary>
        /// <returns>List of organizer users.</returns>
        public static List<object> SelectOrganizers()
        {
            try
            {
                return Orm.db.users
                    .Where(u => u.type == "organizer")
                    .Select(u => new
                    {
                        u.id,
                        u.name,
                        u.email,
                        u.password
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
        /// Retrieves a user entity based on username and password.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <returns>User entity if found, null otherwise.</returns>
        public static users GetUserByCredentials(string username, string password)
        {
            try
            {
                return Orm.db.users.FirstOrDefault(u => u.name == username && u.password == password);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving user: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Updates user details.
        /// </summary>
        /// <param name="id">User ID.</param>
        /// <param name="name">New name.</param>
        /// <param name="email">New email.</param>
        /// <param name="password">New password.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public static bool UpdateUser(int id, string name, string email, string password)
        {
            try
            {
                var user = Orm.db.users.Find(id);
                if (user == null) return false;

                user.name = name;
                user.email = email;
                user.password = password;

                Orm.db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user: " + ex.Message);
                return false;
            }
        }
    }
}