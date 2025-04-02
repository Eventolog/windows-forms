using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Eventology.Forms
{
    public partial class EditSceneryForm : Form
    {
        private PictureBox sala;
        private Button btnAgregarEscenario, btnAgregarButaca;
        private List<Elemento> elementos = new List<Elemento>();
        private Elemento elementoSeleccionado;
        private Point offset;
        private int? lineaAlineacionX = null;
        private int? lineaAlineacionY = null;

        public EditSceneryForm()
        {
            InitializeComponent();

            this.Text = "Editor de Escenarios";
            this.Size = new Size(600, 600);

            sala = new PictureBox()
            {
                BackColor = Color.LightGray,
                Size = new Size(400, 400),
                Location = new Point(100, 50),
                BorderStyle = BorderStyle.FixedSingle
            };
            sala.MouseDown += Sala_MouseDown;
            sala.MouseMove += Sala_MouseMove;
            sala.MouseUp += Sala_MouseUp;
            this.Controls.Add(sala);

            btnAgregarEscenario = new Button() { Text = "Agregar Escenario", Location = new Point(10, 10) };
            btnAgregarEscenario.Click += (s, e) => AgregarEscenario();
            this.Controls.Add(btnAgregarEscenario);

            btnAgregarButaca = new Button() { Text = "Agregar Butaca", Location = new Point(150, 10) };
            btnAgregarButaca.Click += (s, e) => AgregarButaca();
            this.Controls.Add(btnAgregarButaca);
        }

        private void AgregarEscenario()
        {
            Elemento escenario = new Elemento("Escenario", new Rectangle(100, 300, 200, 50), Color.DarkBlue);
            elementos.Add(escenario);
            Renderizar();
        }

        private void AgregarButaca()
        {
            int precio = new Random().Next(10, 100);
            Elemento butaca = new Elemento("Butaca", new Rectangle(150, 150, 30, 30), Color.Red, precio);
            elementos.Add(butaca);
            Renderizar();
        }

        private void Sala_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var elem in elementos)
            {
                if (elem.Bounds.Contains(e.Location))
                {
                    elementoSeleccionado = elem;
                    offset = new Point(e.X - elem.Bounds.X, e.Y - elem.Bounds.Y);
                    break;
                }
            }
        }

        private void Sala_MouseMove(object sender, MouseEventArgs e)
        {
            if (elementoSeleccionado != null && e.Button == MouseButtons.Left)
            {
                int nuevoX = e.X - offset.X;
                int nuevoY = e.Y - offset.Y;

                // Comprobar alineación con otros elementos
                lineaAlineacionX = null;
                lineaAlineacionY = null;
                foreach (var elem in elementos)
                {
                    if (elem != elementoSeleccionado)
                    {
                        if (Math.Abs(elem.Bounds.X - nuevoX) < 10)
                            lineaAlineacionX = elem.Bounds.X;
                        if (Math.Abs(elem.Bounds.Y - nuevoY) < 10)
                            lineaAlineacionY = elem.Bounds.Y;
                    }
                }

                // Ajustar posición para alinear si es necesario
                if (lineaAlineacionX.HasValue)
                    nuevoX = lineaAlineacionX.Value;
                if (lineaAlineacionY.HasValue)
                    nuevoY = lineaAlineacionY.Value;

                elementoSeleccionado.Bounds = new Rectangle(nuevoX, nuevoY, elementoSeleccionado.Bounds.Width, elementoSeleccionado.Bounds.Height);
                Renderizar();
            }
        }

        private void Sala_MouseUp(object sender, MouseEventArgs e)
        {
            if (elementoSeleccionado != null)
            {
                elementoSeleccionado = null;
                lineaAlineacionX = null;
                lineaAlineacionY = null;
                Renderizar();
                GenerarJSON();
            }
        }

        private void Renderizar()
        {
            Bitmap bmp = new Bitmap(sala.Width, sala.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);

                // Dibujar elementos
                foreach (var elem in elementos)
                {
                    using (Brush brush = new SolidBrush(elem.Color))
                    {
                        g.FillRectangle(brush, elem.Bounds);
                    }
                }

                // Dibujar líneas de alineación si existen
                using (Pen pen = new Pen(Color.Green, 2))
                {
                    if (lineaAlineacionX.HasValue)
                        g.DrawLine(pen, new Point(lineaAlineacionX.Value, 0), new Point(lineaAlineacionX.Value, sala.Height));
                    if (lineaAlineacionY.HasValue)
                        g.DrawLine(pen, new Point(0, lineaAlineacionY.Value), new Point(sala.Width, lineaAlineacionY.Value));
                }
            }
            sala.Image = bmp;
        }

        private void GenerarJSON()
        {
            string json = JsonConvert.SerializeObject(elementos, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}

public class Elemento
{
    public string Tipo { get; set; }
    public Rectangle Bounds { get; set; }
    public Color Color { get; set; }
    public int Precio { get; set; }

    public Elemento(string tipo, Rectangle bounds, Color color, int precio = 0)
    {
        Tipo = tipo;
        Bounds = bounds;
        Color = color;
        Precio = precio;
    }
}
