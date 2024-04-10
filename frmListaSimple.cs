using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonceDeLeonMartinaEstrucDatos
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple Lista = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cboLista.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(grillaListaSimple);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cboLista);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;    
        }

        private void cboLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLista.Text == "")
            {
                btnEliminar.Enabled = false;

            }
            else
            {
                btnEliminar.Enabled  = true;
            }
        }
    }
}
