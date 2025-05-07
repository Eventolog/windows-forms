using System;
using System.Linq;
using System.Drawing;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Eventology.Forms.RoomsForm
{
    /// <summary>
    /// Form used for edit a room distribution
    /// </summary>
    public partial class RoomDistributionEditorForm : Form
    {
        /// <summary>
        /// List of created elements
        /// </summary>
        private List<Element> elements = new List<Element>();

        /// <summary>
        /// Stores the last selectedElement
        /// </summary>
        private Element selectedElement;

        /// <summary>
        /// Stores the last seat that was selected
        /// </summary>
        private Seat lastSelectedSeat = null;

        /// <summary>
        /// Stores the unique scenery object
        /// </summary>
        private Scenery scenery = null;

        /// <summary>
        /// Stores the offset between the mouse position and the top-left corner of the selected element.
        /// Used to maintain consistent positioning while dragging elements within the editor
        /// </summary>
        private Point offset;

        /// <summary>
        /// Alignment variables for Left, Top, Right, Bottom
        /// </summary>
        private int? alignmentLineLeft = null;
        private int? alignmentLineTop = null;
        private int? alignmentLineRight = null;
        private int? alignmentLineBottom = null;


        /// <summary>
        /// Total created seats counter
        /// </summary>
        private int seatsAmount = 0;

        /// <summary>
        /// Total existing seats counter
        /// </summary>
        private int seatsExistingAmount = 0;

        /// <summary>
        /// Initialize a room distribution
        /// </summary>
        public RoomDistributionEditorForm()
        {
            InitializeComponent();
            scenery = new Scenery(new Rectangle(0, 0, 400, 50));
            elements.Add(scenery);

            // Add roomPictureBox event listeners
            roomPictureBox.MouseDown += Room_MouseDown;
            roomPictureBox.MouseMove += Room_MouseMove;
            roomPictureBox.MouseUp += Room_MouseUp;

            // initial render
            Render();
        }

        /// <summary>
        /// Handles the MouseDown event on the room picture box.
        /// Determines if a seat is being selected for movement and sets the offset for dragging
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Mouse event arguments containing the position and button info.</param>
        private void Room_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var elem in elements)
            {
                if (elem.Bounds.Contains(e.Location))
                {
                    // only allow seat moving
                    if (elem is Seat)
                    {
                        Seat seat = (Seat)elem;
                        lastSelectedSeat = seat;
                        inputPriceEdit.Value = seat.Price;
                        selectedElement = elem;
                        offset = new Point(e.X - elem.Bounds.X, e.Y - elem.Bounds.Y);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the MouseMove event on the room picture box
        /// Updates the position of the selected element (seat) while aligning with nearby elements
        /// Triggers re-rendering of the layout with alignment guidelines if applicable
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Mouse event arguments containing the current mouse position.</param>
        private void Room_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedElement != null && e.Button == MouseButtons.Left)
            {
                int newX = e.X - offset.X;
                int newY = e.Y - offset.Y;
                int newXRight = newX + selectedElement.Bounds.Width;
                int newYBottom = newY + selectedElement.Bounds.Height;

                // Reset alignment lines
                alignmentLineLeft = null;
                alignmentLineTop = null;
                alignmentLineRight = null;
                alignmentLineBottom = null;

                // Check alignment with other elements (left, right, top, bottom)
                foreach (var elem in elements)
                {
                    if (elem != selectedElement)
                    {
                        // Left alignment (selected left with element's left)
                        if (Math.Abs(elem.Bounds.Left - newX) < 10)
                            alignmentLineLeft = elem.Bounds.Left;

                        // Right alignment (selected right with element's left)
                        if (Math.Abs(elem.Bounds.Left - newXRight) < 10)
                            alignmentLineRight = elem.Bounds.Left - selectedElement.Bounds.Width;

                        // Top alignment (selected top with element's top)
                        if (Math.Abs(elem.Bounds.Top - newY) < 10)
                            alignmentLineTop = elem.Bounds.Top;

                        // Bottom alignment (selected bottom with element's top)
                        if (Math.Abs(elem.Bounds.Top - newYBottom) < 10)
                            alignmentLineBottom = elem.Bounds.Top - selectedElement.Bounds.Height;

                        // Right alignment (selected right with element's right)
                        if (Math.Abs(elem.Bounds.Right - newXRight) < 10)
                            alignmentLineRight = elem.Bounds.Right - selectedElement.Bounds.Width;

                        // Left alignment (selected left with element's right)
                        if (Math.Abs(elem.Bounds.Right - newX) < 10)
                            alignmentLineLeft = elem.Bounds.Right;

                        // Bottom alignment (selected bottom with element's bottom)
                        if (Math.Abs(elem.Bounds.Bottom - newYBottom) < 10)
                            alignmentLineBottom = elem.Bounds.Bottom - selectedElement.Bounds.Height;

                        // Top alignment (selected top with element's bottom)
                        if (Math.Abs(elem.Bounds.Bottom - newY) < 10)
                            alignmentLineTop = elem.Bounds.Bottom;
                    }
                }

                // Adjust position based on alignment lines
                if (alignmentLineLeft.HasValue)
                    newX = alignmentLineLeft.Value;
                if (alignmentLineTop.HasValue)
                    newY = alignmentLineTop.Value;
                if (alignmentLineRight.HasValue)
                    newX = alignmentLineRight.Value;
                if (alignmentLineBottom.HasValue)
                    newY = alignmentLineBottom.Value;

                // Set the new position of the selected element
                selectedElement.Bounds = new Rectangle(newX, newY, selectedElement.Bounds.Width, selectedElement.Bounds.Height);

                // Render the updated layout
                Render();
            }
        }

        /// <summary>
        /// Handles the MouseUp event on the room picture box
        /// Finalizes the movement of the selected element and clears alignment guidelines
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Mouse event arguments containing the release position.</param>
        private void Room_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedElement != null)
            {
                selectedElement = null;
                // Reset all alignment lines
                alignmentLineLeft = null;
                alignmentLineTop = null;
                alignmentLineRight = null;
                alignmentLineBottom = null;
                Render();
            }
        }

        /// <summary>
        /// Renders the room layout by drawing all elements and alignment guides on a bitmap canvas.
        /// The bitmap is then displayed in the PictureBox control.
        /// </summary>
        private void Render()
        {
            Bitmap bmp = new Bitmap(roomPictureBox.Width, roomPictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);

                // Draw elements
                foreach (var elem in elements)
                {
                    Color fillColor;
                    string overlayText = null; // Text to draw over element
                    Font overlayFont = new Font("Arial", 10, FontStyle.Bold);
                    Brush textBrush = Brushes.White;

                    if (elem.Type == RoomElementTypes.Seat)
                    {
                        var seat = (Seat)elem;
                        if (lastSelectedSeat != null && seat.Id == lastSelectedSeat.Id)
                        {
                            // Draw a white border around the selected seat
                            using (Pen borderPen = new Pen(Color.White, 3)) // 3 pixels width
                            {
                                g.DrawRectangle(borderPen, seat.Bounds);
                            }
                        }

                        fillColor = Color.Red;
                        overlayText = $"${seat.Price:F2}";  // Show seat price
                    }
                    else if (elem.Type == RoomElementTypes.Scenery)
                    {
                        fillColor = Color.DarkBlue;
                        overlayText = "Escenari";
                    }
                    else
                    {
                        fillColor = Color.AliceBlue;
                    }

                    using (Brush brush = new SolidBrush(fillColor))
                    {
                        g.FillRectangle(brush, elem.Bounds);
                    }

                    // Draw text if available
                    if (!string.IsNullOrEmpty(overlayText))
                    {
                        // Center the text
                        SizeF textSize = g.MeasureString(overlayText, overlayFont);
                        float textX = elem.Bounds.X + (elem.Bounds.Width - textSize.Width) / 2;
                        float textY = elem.Bounds.Y + (elem.Bounds.Height - textSize.Height) / 2;

                        g.DrawString(overlayText, overlayFont, textBrush, textX, textY);
                    }
                }


                // Draw alignment lines if they exist
                using (Pen pen = new Pen(Color.Green, 2))
                {
                    if (alignmentLineLeft.HasValue)
                        g.DrawLine(pen, new Point(alignmentLineLeft.Value, 0), new Point(alignmentLineLeft.Value, roomPictureBox.Height));

                    if (alignmentLineTop.HasValue)
                        g.DrawLine(pen, new Point(0, alignmentLineTop.Value), new Point(roomPictureBox.Width, alignmentLineTop.Value));

                    if (alignmentLineRight.HasValue)
                        g.DrawLine(pen, new Point(alignmentLineRight.Value + selectedElement.Bounds.Width, 0), new Point(alignmentLineRight.Value + selectedElement.Bounds.Width, roomPictureBox.Height));

                    if (alignmentLineBottom.HasValue)
                        g.DrawLine(pen, new Point(0, alignmentLineBottom.Value + selectedElement.Bounds.Height), new Point(roomPictureBox.Width, alignmentLineBottom.Value + selectedElement.Bounds.Width));
                }
            }
            roomPictureBox.Image = bmp;
            GenerateJSON();
        }

        /// <summary>
        /// Generates a JSON representation of the current room layout,
        /// including all seats and the scenery. The result is output to the console and a text box
        /// </summary>
        private void GenerateJSON()
        {
            // Filter elements to get only the seats (butacas)
            var seatElements = elements
                .Where(e => e.Type == RoomElementTypes.Seat) // Filter by type 'Seat'
                .Cast<Seat>() // Cast the filtered elements to Seat
                .Select(seat => new
                {
                    seat.Bounds, // Only include Bounds
                    seat.Price   // Include Price as well
                })
                .ToArray(); // Convert the result to an array

            // Filter elements to get only the scenery (Scenery)
            var sceneryElements = elements
                .Where(e => e.Type == RoomElementTypes.Scenery) // Filter by type 'Scenery'
                .ToArray(); // Convert the result to an array (no need to cast to Scenery since it's already of that type)

            // Create the JSON object with the filtered and cleaned data
            var jsonObject = new
            {
                Scenery = sceneryElements, // Add Scenery elements as they are
                Seats = seatElements        // Add cleaned and transformed Seat elements
            };

            string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            Console.WriteLine(json);
            textBox1.Text = json;
        }

        /// <summary>
        /// Handles the Add Seat button click event
        /// Creates a new seat with the specified price and adds it to the room layout
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void addSeat_Click(object sender, EventArgs e)
        {
            seatsAmount += 1;
            seatsExistingAmount += 1;
            int seatId = seatsAmount;
            decimal price = numericPrice.Value;
            Element seat = new Seat(new Rectangle(150, 150, 30, 30), price, seatId);
            qtySeat.Text = seatsExistingAmount.ToString();
            elements.Add(seat);
            Render();
        }

        /// <summary>
        /// Handles the Delete Seat button click event
        /// Prompts user for confirmation before removing the last selected seat from the layout
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void deleteSeat_Click(object sender, EventArgs e)
        {
            if (lastSelectedSeat == null)
            {
                MessageBoxUtility.ShowError("No has seleccionat cap butaca");
                return;
            }

            bool confirm = MessageBoxUtility.ShowConfirm("Estas segur vols eliminar la butaca amb id: " + lastSelectedSeat.Id + " i preu: " + lastSelectedSeat.Price);
            if (confirm)
            {
                RemoveSeatById(lastSelectedSeat.Id);
                seatsExistingAmount -= 1;
                lastSelectedSeat = null;
                qtySeat.Text = seatsExistingAmount.ToString();

                // selectedElement is a Seat
                Render();
            }

        }

        /// <summary>
        /// Removes a seat from the layout by its unique ID
        /// Updates internal state and resets relevant UI fields
        /// </summary>
        /// <param name="seatId">The unique identifier of the seat to remove.</param>
        private void RemoveSeatById(int seatId)
        {
            // Find the seat element with the given ID
            var seatToRemove = elements.OfType<Seat>().FirstOrDefault(seat => seat.Id == seatId);

            if (seatToRemove != null)
            {
                // Remove the found seat from the elements collection
                elements.Remove(seatToRemove);
                lastSelectedSeat = null;
                inputPriceEdit.Value = 0;
                Console.WriteLine($"Seat with ID {seatId} has been removed.");
            }
            else
            {
                Console.WriteLine($"No seat found with ID {seatId}.");
            }
        }


        /// <summary>
        /// Handles the Edit Seat button click event
        /// Updates the price of the currently selected seat after validation
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void editSeat_Click(object sender, EventArgs e)
        {
            if (lastSelectedSeat == null)
            {
                MessageBoxUtility.ShowError("No has seleccionat cap butaca per editar.");
                return;
            }

            decimal newPrice = inputPriceEdit.Value;

            if (newPrice <= 0)
            {
                MessageBoxUtility.ShowError("El preu ha de ser major que 0.");
                return;
            }

            lastSelectedSeat.Price = newPrice;

            Console.WriteLine($"Seat ID {lastSelectedSeat.Id} updated with new price: {newPrice}");

            Render();
        }

    }

}