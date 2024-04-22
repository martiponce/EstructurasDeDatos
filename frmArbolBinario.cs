using System;
using System.Collections;
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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario arbol = new clsArbolBinario();

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cboCodigo.Text);
               // arbol.Eliminar(x);
                arbol.Recorrer(grillaArbolBinario);


                // Actualiza el ComboBox después de eliminar un nodo
                arbol.Recorrer(cboCodigo);
                
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Tramite = txtTramite.Text;
            arbol.Agregar(obj);
            arbol.Recorrer(grillaArbolBinario);
            arbol.Recorrer(treeView);
            arbol.Recorrer(cboCodigo);
            txtTramite.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
        }
    }
}
