using Eventology.Models;

namespace Eventology.Utils
{
    /// <summary>
    /// Represents the current active user session in the application.
    /// This static class holds the reference to the logged-in user,
    /// making it accessible globally across the application.
    /// </summary>
    public static class CurrentSession
    {
        /// <summary>
        /// Gets or sets the user currently logged in.
        /// </summary>
        public static users LoggedUser { get; set; }
    }
}