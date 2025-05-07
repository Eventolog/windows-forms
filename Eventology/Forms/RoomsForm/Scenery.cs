using System.Drawing;


namespace Eventology.Forms.RoomsForm
{
    /// <summary>
    /// Represents a scenery element within a room layout, 
    /// Inherits from <see cref="Element"/>.
    /// </summary>
    public class Scenery : Element
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Scenery"/> class with the specified bounds.
        /// </summary>
        /// <param name="bounds">The rectangular bounds of the scenery element.</param>
        public Scenery(Rectangle bounds)
            : base(bounds, RoomElementTypes.Scenery)
        {
        }
    }
}
