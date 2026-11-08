using Ejercicio4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Icon = Resources.img1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAniadir, "Añade el texto a la primera lista");
            toolTip1.SetToolTip(btnQuitar, "Elimina los indices seleccionados de la lista indicada");
            toolTip1.SetToolTip(btnTraspasar, "Traspasa los indices seleccionados de una lista a otra segun lo indicado");
            toolTip1.SetToolTip(lst2, "Total de elementos en el listbox 2: 0");
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            if (txt_texto.Text.Length >0 && !lst1.Items.Contains(txt_texto.Text))
            {
                lst1.Items.Add(txt_texto.Text);
            }
            actualizarLabels();


        }

        private void txt_texto_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnAniadir;
        }

        private void rbElim1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbElim1.Checked)
            {
                btnQuitar.Text = "Elimina de 1";
            }
            else
            {
                btnQuitar.Text = "Elimina de 2";
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (rbElim1.Checked)
            {
                for(int i = lst1.SelectedIndices.Count - 1; i >=0; i--)
                {
                    lst1.Items.RemoveAt(lst1.SelectedIndices[i]);
                }
                
            }
            else
            {
                lst2.Items.Remove(lst2.SelectedItem);
            }
            actualizarLabels();

        }

        private void rbTras1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTras1.Checked)
            {
                btnTraspasar.Text = "Traspaso 1 -> 2";
            }else
            {
                btnTraspasar.Text = "Traspaso 2 -> 1";
            }
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            if (rbTras1.Checked)
            {
                for (int i = lst1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int posicion = lst1.SelectedIndices[i];

                    lst2.Items.Add(lst1.Items[posicion]);
                    lst1.Items.RemoveAt(posicion);
                }
            }
            else
            {
                lst1.Items.Add(lst2.SelectedItem);
                lst2.Items.Remove(lst2.SelectedItem);
            }
            actualizarLabels();
        }

        private void actualizarLabels()
        {
            
            string muestra = "";
            lblTotales.Text = "Total de elementos en el listbox 1: " + lst1.Items.Count;
            
            foreach(int indice in lst1.SelectedIndices)
            {
                muestra += indice + " ";
            }
            lblSeleccionados.Text = "Indices de los elementos seleccionados en listbox 1: " + muestra;

            toolTip1.SetToolTip(lst2, "Total de elementos en el listbox 2: " + lst2.Items.Count);
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLabels();
        }

        private static string titulo = "Titulo tope de guapo, joder soy down";
        private int cont = titulo.Length;
        private bool img1Activa = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                this.Text = titulo.Substring(cont);
                cont--;
            }
            else
            {
                this.Text = titulo.Substring(cont);
                cont = titulo.Length;
                if (img1Activa)
                {
                    this.Icon = Resources.img2;
                    img1Activa = false;
                }
                else
                {
                    this.Icon = Resources.img1;
                    img1Activa = true;
                }
                
            }
        }
    }
}
