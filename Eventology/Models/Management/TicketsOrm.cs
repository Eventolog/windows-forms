using System;
using System.Linq;

namespace Eventology.Models.Management
{
    public static class TicketsOrm
    {
        public static int GetTotalSoldTickets()
        {
            try
            {
                return Orm.db.tickets.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error comptant entrades venudes: " + ex.Message);
                return 0;
            }
        }
    }
}