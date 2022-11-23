using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Doblemente_Enlazada_Circular_N_1
{
    public partial class Form1 : Form
    {
        private int n = 0;
        ListaAsig Lista1;
        public Form1()
        {
            InitializeComponent();
            Lista1 = new ListaAsig();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Escriba los datos");
                return;
            }
            else
            {
                Lista1.CrearLista(textBox1.Text, int.Parse(textBox2.Text));
                textBox1.Text = "Escriba aqui";
                textBox2.Text = "";
                textBox1.Focus();
                textBox1.Text = null;
                textBox2.Text = null;
                listBox1.Items.Add(x);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //TNodo elim;
            if (Lista1.BuscarAsignado(textBox1.Text))
            {
                //elim = (TNodo)Lista1.Eliminar();
                Lista1.EliminarLista(textBox1.Text);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
                MessageBox.Show("Lista Vacia");
        }

        private void Primero_Click(object sender, EventArgs e)
        {
            TNodo nodoPrimero;
            nodoPrimero = (TNodo)Lista1.GetPrimero();
            if(nodoPrimero == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }
            else
            {
                textBox1.Text = nodoPrimero.DameNombre();
                textBox2.Text = nodoPrimero.DameNumero().ToString();
            }
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            if (Lista1.BuscarAsignado(textBox1.Text) == true)
            {
                TNodo nodoAnterior = (TNodo)Lista1.GetAnteriorCursor();
                textBox1.Text = nodoAnterior.DameNombre();
                textBox2.Text = (nodoAnterior.DameNumero()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene sucesor");
            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            TNodo nodoSiguiente;
            if (Lista1.BuscarAsignado(textBox1.Text) == true)
            {
                nodoSiguiente = (TNodo)Lista1.GetProxCursor();
                textBox1.Text = nodoSiguiente.DameNombre();
                textBox2.Text = (nodoSiguiente.DameNumero()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene nodo siguiente");
            }
        }

        private void Ultimo_Click(object sender, EventArgs e)
        {
            TNodo nodoUltimo;
            nodoUltimo = (TNodo)Lista1.GetUltimo();
            if (nodoUltimo == null)
            {
                MessageBox.Show("Lista Vacia");
                return;
            }
            else
            {
                textBox1.Text = nodoUltimo.DameNombre();
                textBox2.Text = nodoUltimo.DameNumero().ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Escriba los datos");
                return;
            }
            else
            {
                Lista1.CrearLista2(textBox1.Text, int.Parse(textBox2.Text));
                textBox1.Text = "Escriba aqui";
                textBox2.Text = "";
                textBox1.Focus();
                textBox1.Text = null;
                textBox2.Text = null;
                listBox1.Items.Add(x);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                                         
        }

        private void insertDA_Click(object sender, EventArgs e)
        {
            // adicionamos nuevo renglon
            int n = dataGridView1.Rows.Add("fsdsdadasdas");
            //colocamos la informacion 
            dataGridView1.Rows[n].Cells[0].Value = txtnombre.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtcodigo.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtsalario.Text;
            // limpiamos las barras de texto 
            txtnombre.Clear();txtcodigo.Clear();txtsalario.Clear();
            txtnombre.Focus();
            dataGridView1.ClearSelection();

        }
public int cont = 0;
        private void eliminarDA_Click(object sender, EventArgs e)
        {
           
            if(n!=-1)
            {
                dataGridView1.Rows.RemoveAt(n);
                cont++;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {label7.Text = (string)dataGridView1.Rows[n].Cells[0].Value;
                label8.Text = (string)dataGridView1.Rows[n].Cells[1].Value;
                label9.Text = (string)dataGridView1.Rows[n].Cells[2].Value;
                
            }
        }

        private void vaciar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            listBox1.Items.Add(cont);
        }
    }
}
