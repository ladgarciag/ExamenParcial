using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial
{
     
    public partial class Form1 : Form
    {

        ListaSimplementeEnlazadaCircularCabeza lseCabeza = new ListaSimplementeEnlazadaCircularCabeza();
        public Form1()
        {
            InitializeComponent();
        }
        void MostrarLSEC()
        {
            Nodo p;
            lview.Clear();
            p = lseCabeza.Primero;
            while (p != null)
            {
                if (!lseCabeza.Vacia())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.Enlace;
                }
            }
        }

        private void btnInsCab_Click(object sender, EventArgs e)
        {

            if (txtbox.Text != "")
            {
                lseCabeza.InsertarOrdenado(Int32.Parse(txtbox.Text));
                MostrarLSEC();
                txtbox.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }
        private void txtIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtbox.Text != "")
                {

                    lseCabeza.InsertarOrdenado(Int32.Parse(txtbox.Text));
                    MostrarLSEC();
                    txtbox.Clear();
                }
                else
                {
                    MessageBox.Show("***Error, introduza un valor***");
                }
            }

        }
    }
}
