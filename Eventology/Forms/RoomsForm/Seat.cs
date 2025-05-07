using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventology.Forms.RoomsForm
{
    /// <summary>
    /// Represents a seat element within a room layout. 
    /// Inherits from <see cref="Element"/> and includes additional properties like price and seat ID.
    /// </summary>
    public class Seat : Element
    {
        /// <summary>
        /// Gets or sets the price of the seat.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets the unique identifier for the seat.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seat"/> class with the specified bounds, price, and ID.
        /// </summary>
        /// <param name="bounds">The rectangular bounds of the seat.</param>
        /// <param name="price">The price associated with the seat.</param>
        /// <param name="id">The unique identifier of the seat in the root layout.</param>
        public Seat(Rectangle bounds, decimal price, int id)
            : base(bounds, RoomElementTypes.Seat)
        {
            Price = price;
            Id = id;
        }
    }
}
