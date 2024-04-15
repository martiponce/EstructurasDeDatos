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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Lista = new clsListaDoble();

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            // Cambia la siguiente línea para trabajar con clsListaSimple en lugar de clsCola
            Lista.Agregar(objNodo);

          
            // Limpia los campos de texto después de agregar el nodo
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void radDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (radDescendente.Checked)
            {
                Lista.RecorrerDesc(grillaListaDoble);
                Lista.RecorrerDesc(lstListaDoble);
                Lista.RecorrerDesc();
            }
        }

        private void radAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (radAscendente.Checked)
            {
                Lista.Recorrer(grillaListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
               
              
                Lista.Recorrer(grillaListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.RecorrerDesc();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;
        }

        
    }
}
