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
        private clsArbolBinario Arbol = new clsArbolBinario();

        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Arbol.Agregar(objNodo);
            

            // Actualizar controles después de agregar el nodo
            ActualizarControles();

            // Limpiar campos de texto
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedItem != null)
            {
                int codigoSeleccionado = Convert.ToInt32(cboCodigo.SelectedItem);

                // Eliminar el nodo con el código seleccionado del árbol
                Arbol.Eliminar(codigoSeleccionado);

                // Actualizar controles después de eliminar el nodo
                ActualizarControles();
            }
            else
            {
                MessageBox.Show("Seleccione un código para eliminar.");
            }
        }

        private void radInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            
            ActualizarControles();
        }

        private void radPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            
            ActualizarControles();

        }

        private void radPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            
            ActualizarControles();

        }

        private void rdInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
           
            ActualizarControles();
        }

        private void ActualizarControles()
        {
            treeView.Nodes.Clear(); // Limpiar el TreeView antes de cargar
            grillaArbolBinario.Rows.Clear(); // Limpiar la grilla antes de cargar

            //metodos segun lo sleccionado
            if (radInOrdenAsc.Checked)
            {
                cboCodigo.Items.Clear();
                Arbol.InOrdenAsc(cboCodigo, Arbol.Raiz);
                Arbol.CargarTreeView(treeView);
                Arbol.CargarGrillaInOrden(grillaArbolBinario);
            }
            else if (rdInOrdenDesc.Checked)
            {
                cboCodigo.Items.Clear();
                Arbol.InOrdenDesc(cboCodigo, Arbol.Raiz);
                Arbol.CargarTreeView(treeView);
                Arbol.CargarGrillaInOrdenDesc(grillaArbolBinario);
            }
            else if (radPreOrden.Checked)
            {
                cboCodigo.Items.Clear();
                Arbol.PreOrden(cboCodigo, Arbol.Raiz);
                Arbol.CargarTreeView(treeView);
                Arbol.CargarGrillaPreOrden(grillaArbolBinario);
            }
            else if (rdPostOrden.Checked)
            {
                cboCodigo.Items.Clear();
                Arbol.PostOrden(cboCodigo, Arbol.Raiz);
                Arbol.CargarTreeView(treeView);
                Arbol.CargarGrillaPostOrden(grillaArbolBinario);
            }

            // Expandir todos los nodos del TreeView
            treeView.ExpandAll();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            radInOrdenAsc.Checked = true;

        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
        }

       
    }
}
