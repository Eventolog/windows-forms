using System.Drawing;


namespace Eventology.Forms.Rooms
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
        /// Gets or set in the row of the room where the seat is at
        /// </summary>
        public int Row { get; set; }

        /// <summary>
        /// Gets or set the unique seatNumber for the given row
        /// </summary>
        public int SeatNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Seat"/> class with the specified bounds, price, and ID.
        /// </summary>
        /// <param name="bounds">The rectangular bounds of the seat.</param>
        /// <param name="price">The price associated with the seat.</param>
        /// <param name="row">The row of the room where the seat is at.</param>
        /// <param name="seatNumber">Unique seatNumber for the given row.</param>
        /// <param name="id">The unique identifier of the seat in the root layout.</param>
        public Seat(Rectangle bounds, decimal price, int id, int row, int seatNumber)
            : base(bounds, RoomElementTypes.Seat)
        {
            Price = price;
            Id = id;
            Row = row;
            SeatNumber = seatNumber;
        }
    }
}
