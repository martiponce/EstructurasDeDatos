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
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            // Cambia la siguiente línea para trabajar con clsListaSimple en lugar de clsCola
            Lista.Agregar(objNodo);

            // Actualiza la interfaz gráfica llamando a los métodos de Recorrer
            Lista.Recorrer(grillaListaSimple);
            Lista.Recorrer(lstListaSimple);
            Lista.Recorrer(cboLista);
            Lista.Recorrer(); 

            // Limpia los campos de texto después de agregar el nodo
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cboLista.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(grillaListaSimple);
                Lista.Recorrer(lstListaSimple);

                // Actualiza el ComboBox después de eliminar un nodo
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

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
