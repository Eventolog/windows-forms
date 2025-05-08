using System;
using System.Linq;

namespace Eventology.Models.Management
{
    /// <summary>
    /// Provides operations to manage and query ticket-related data from the database.
    /// </summary>
    public static class TicketsOrm
    {
        /// <summary>
        /// Retrieves the total number of tickets in the system (sold, reserved, etc.).
        /// </summary>
        /// <returns>The total count of ticket records.</returns>
        public static int GetTotalSoldTickets()
        {
            try
            {
                return Orm.db.tickets.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting sold tickets: " + ex.Message);
                return 0;
            }
        }
    }
}