using System.Drawing;


namespace Eventology.Forms.Rooms
{
    /// <summary>
    /// Represents an abstract square element used in the room layout distribution.
    /// This class provides basic properties such as type and bounding box.
    /// </summary>
    public abstract class Element
    {
        /// <summary>
        /// Gets or sets the type of the element (e.g., Chair, Table, Stage).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the bounding rectangle of the element, which determines its position and size.
        /// </summary>
        public Rectangle Bounds { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class with the specified bounds and type.
        /// </summary>
        /// <param name="bounds">The rectangular bounds of the element.</param>
        /// <param name="type">The type or category of the element.</param>
        public Element(Rectangle bounds, string type)
        {
            Bounds = bounds;
            Type = type;
        }
    }
}
