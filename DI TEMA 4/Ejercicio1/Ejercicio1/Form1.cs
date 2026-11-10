using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private string tituloOriginal;
        public Form1()
        {
            InitializeComponent();
            tituloOriginal = this.Text;
            this.KeyPreview = true;
            CrearBotones();

        }

        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            if (sender is Button)
            {
                Button b = (Button)sender;
                x += b.Location.X;
                y += b.Location.Y;
            }

            this.Text = "x:" + x + ", y:" + y;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Blue;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.WhiteSmoke;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.WhiteSmoke;
            }
            else
            {
                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
            }

        }



        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.WhiteSmoke;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.WhiteSmoke;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Blue;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.WhiteSmoke;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.WhiteSmoke;
            }
            else
            {
                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = tituloOriginal;
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }
        }

        private void CrearBotones()
        {
            int ancho = 70;
            int alto = 50;
            int margen = 10;
            int inicioX = 20;
            int inicioY = button2.Location.Y + button2.Height + 50;

            int contF = 0;
            int contC = 0;
            for (int i = 0; i < 20; i++)
            {

                Button b = new Button();
                b.Text = (i + 1).ToString();
                b.Size = new Size(ancho, alto);
                b.Location = new Point(inicioX + contF * (ancho + margen), inicioY + contC * (alto + margen));

                contF++;
                if (contF == 5)
                {
                    contF = 0;
                    contC++;
                }

                b.MouseMove += Form1_MouseMove;
                b.MouseDown += BotonNumerado_MouseDown;
                b.MouseUp += BotonNumerado_MouseUp;

                this.Controls.Add(b);

            }
        }

        private void BotonNumerado_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
        }

        private void BotonNumerado_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que deseas salir?", "Cosa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
