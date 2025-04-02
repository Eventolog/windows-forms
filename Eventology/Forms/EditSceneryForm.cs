using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Eventology.Forms
{
    public partial class EditSceneryForm : Form
    {
        private List<Element> elements = new List<Element>();
        private Element selectedElement;
        private Seat lastSelectedSeat = null;
        private Scenery scenery = null;
        private Point offset;

        // New alignment variables for Left, Top, Right, Bottom
        private int? alignmentLineLeft = null;
        private int? alignmentLineTop = null;
        private int? alignmentLineRight = null;
        private int? alignmentLineBottom = null;
        private int seatsAmount = 0;

        public EditSceneryForm()
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

        private void Room_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var elem in elements)
            {
                if (elem.Bounds.Contains(e.Location))
                {
                    // only allow seat moving
                    if(elem is Seat)
                    {
                        Seat seat = (Seat)elem;
                        lastSelectedSeat = seat;
                        selectedElement = elem;
                        offset = new Point(e.X - elem.Bounds.X, e.Y - elem.Bounds.Y);
                        break;
                    }
                }
            }
        }

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
                GenerateJSON();
            }
        }

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

                    if (elem.Type == ElementTypes.Seat)
                    {
                        var seat = (Seat)elem;
                        if (lastSelectedSeat != null)
                        {
                            // Check if this seat is the last selected seat
                            if (seat.Id == lastSelectedSeat.Id)
                            {
                                // Draw a white border around the selected seat
                                using (Pen borderPen = new Pen(Color.White, 3))  // 3 pixels width for the border
                                {
                                    g.DrawRectangle(borderPen, seat.Bounds);
                                }
                            }
                        }
                        

                        fillColor = Color.Red;  // Seat color
                    }
                    else if (elem.Type == ElementTypes.Scenery)
                    {
                        fillColor = Color.DarkBlue;  // Scenery color
                    }
                    else
                    {
                        fillColor = Color.AliceBlue;
                    }

                    using (Brush brush = new SolidBrush(fillColor))
                    {
                        g.FillRectangle(brush, elem.Bounds);
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
        }

        private void GenerateJSON()
        {
            // Filter elements to get only the seats (butacas)
            var seatElements = elements
                .Where(e => e.Type == ElementTypes.Seat) // Filter by type 'Seat'
                .Cast<Seat>() // Cast the filtered elements to Seat
                .Select(seat => new
                {
                    seat.Bounds, // Only include Bounds
                    seat.Price   // Include Price as well
                })
                .ToArray(); // Convert the result to an array

            // Filter elements to get only the scenery (Scenery)
            var sceneryElements = elements
                .Where(e => e.Type == ElementTypes.Scenery) // Filter by type 'Scenery'
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

        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            seatsAmount += 1;
            int seatId = seatsAmount;
            decimal price = numericPrice.Value;
            Element seat = new Seat(new Rectangle(150, 150, 30, 30), price, seatId);
            elements.Add(seat);
            Render();
        }

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
                lastSelectedSeat = null;
                // selectedElement is a Seat
                Render();
            }
        }

        private void RemoveSeatById(int seatId)
        {
            // Find the seat element with the given ID
            var seatToRemove = elements.OfType<Seat>().FirstOrDefault(seat => seat.Id == seatId);

            if (seatToRemove != null)
            {
                // Remove the found seat from the elements collection
                elements.Remove(seatToRemove);
                Console.WriteLine($"Seat with ID {seatId} has been removed.");
            }
            else
            {
                Console.WriteLine($"No seat found with ID {seatId}.");
            }
        }

    }
}

public static class ElementTypes
{
    public const string Scenery = "Scenery";
    public const string Seat = "Seat";
}

public class Seat : Element
{
    public decimal Price { get; set; }
    public int Id { get; set; }
    public Seat(Rectangle bounds, decimal price, int id)
        : base(bounds, ElementTypes.Seat)
    {
        Price = price;
        Id = id;
    }
}

public class Scenery : Element
{
    public Scenery(Rectangle bounds)
        : base(bounds, ElementTypes.Scenery)
    {
    }
}

public class Element
{
    public string Type { get; set; }
    public Rectangle Bounds { get; set; }

    public Element(Rectangle bounds, string type)
    {
        Bounds = bounds;
        Type = type;
    }
}
