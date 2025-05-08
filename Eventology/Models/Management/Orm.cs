using System.Data.SqlClient;

namespace Eventology.Models.Management
{
    /// <summary>
    /// Provides access to the database context and centralized SQL error handling.
    /// </summary>
    class Orm
    {
        /// <summary>
        /// Entity Framework database context for accessing the Eventology database.
        /// </summary>
        public static eventologyEntities db = new eventologyEntities();

        /// <summary>
        /// Returns a human-readable error message based on a SqlException.
        /// </summary>
        /// <param name="sqlException">The SqlException thrown during a database operation.</param>
        /// <returns>A string describing the error in a friendly or informative way.</returns>
        public static string ErrorMessage(SqlException sqlException)
        {
            string message = "";

            switch (sqlException.Number)
            {
                case 2:
                    message = "The server is not operational.";
                    break;
                case 547:
                    message = "The record cannot be deleted because it has related records.";
                    break;
                case 4060:
                    message = "Could not connect to the database.";
                    break;
                case 18456:
                    message = "Login failed.";
                    break;
                case 2601:
                    message = "A record with the same value already exists.";
                    break;
                default:
                    message = sqlException.Number + " - " + sqlException.Message;
                    break;
            }

            return message;
        }
    }
}