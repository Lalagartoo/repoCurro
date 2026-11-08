using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tBotones = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#"};
            int ancho = 75;
            int alto = 75;
            int margen = 5;
            int inicioX = txtEscrito.Location.X;
            int inicioY = txtEscrito.Location.Y + txtEscrito.Height + 5;

            int contX = 0;
            int contY = 0;
            for (int i = 0; i < tBotones.Length; i++)
            {
                Button b = new Button();
                b.Text = tBotones[i];
                b.Size = new Size(ancho, alto);

                b.Location = new Point(inicioX + contX*(ancho + margen), inicioY+ contY*(alto+margen));
                b.Click += btnCLick;
                b.MouseEnter += btnMouseEnter;
                b.MouseLeave += btnMouseLeave;
                this.Controls.Add(b);
                if (contX == 2)
                {
                    contX = 0;
                    contY++;
                }
                else
                {
                    contX++;
                }
                
            }

            Button btnReset = new Button();
            btnReset.Text = "Reset";
            btnReset.Size = new Size (75, 23);
            btnReset.Location = new Point(inicioX +contX*(ancho+margen), inicioY+ contY*(alto+margen));
            btnReset.Click += resetTodo;
            this.Controls.Add(btnReset);
            
        }

        private void btnCLick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtEscrito.Text += b.Text;
            txtEscrito.Focus();
            txtEscrito.SelectionStart = txtEscrito.Text.Length;
            txtEscrito.SelectionLength = 0;

            b.BackColor = Color.Orange;
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor != Color.Orange)
            {
                b.BackColor = Color.LightSkyBlue;
            }
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
                Button b = (Button)sender;
            if (b.BackColor != Color.Orange)
            {
                b.BackColor = Color.White;
            }
        }

        private void txtEscrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esPermitido = char.IsDigit(e.KeyChar) || e.KeyChar == '*' || e.KeyChar == '#';

            if (!esPermitido)
            {
                e.Handled = true;
            }
        }

        private void resetTodo(object sender, EventArgs e)
        {
            txtEscrito.Text = "";
            foreach(Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.BackColor = Color.White;
                }
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion de teclado creada por Lucas Junquera Loureiro.", "Acerca de...",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTodo(sender, EventArgs.Empty);
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(txtEscrito.Text == "")
            {
                return;
            }
            Form2 f = new Form2();

            if (f.ShowDialog() == DialogResult.OK)
            {
                if(f.txtNombre.Text != "")
                {
                    StreamWriter sw = new StreamWriter("agenda.txt", true);
                    sw.WriteLine(f.txtNombre.Text+":"+txtEscrito.Text);
                    sw.Close();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form3 f;
        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = "agenda.txt";
            if (f != null && !f.IsDisposed)
            {
                return;
            }

            if (!File.Exists(ruta))
            {
                return;
            }

            string texto = "Nombre".PadRight(25) + "Telefono" + Environment.NewLine;

            StreamReader sr = new StreamReader("agenda.txt");
            string linea;
            while((linea = sr.ReadLine()) != null)
            {
                string[] partes = linea.Split(':');
                texto += partes[0].PadRight(25) + partes[1]+ Environment.NewLine;
            }
            sr.Close();

            f = new Form3();
            f.textBox1.Text = texto;
            f.Show();
        }
    }
}
