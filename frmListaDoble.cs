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
            radAscendente.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verifica que el texto en txtCodigo.Text sea un número válido
            if (int.TryParse(txtCodigo.Text, out int codigo))
            {
                clsNodo objNodo = new clsNodo();
                objNodo.Codigo = codigo;
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;

                // Agrega el nodo a la lista
                Lista.Agregar(objNodo);

                // Actualiza la interfaz gráfica después de agregar un nodo
                if (radAscendente.Checked)
                {
                    Lista.Recorrer(grillaListaDoble);
                    Lista.Recorrer(lstListaDoble);
                    Lista.Recorrer();
                }
                else if (radDescendente.Checked)
                {
                    Lista.RecorrerDesc(grillaListaDoble);
                    Lista.RecorrerDesc(lstListaDoble);
                    Lista.RecorrerDesc();
                }
            }
            else
            {
                MessageBox.Show("El código ingresado no es válido. Por favor, ingrese un número entero.");
            }

            // Limpia los campos de texto después de agregar el nodo
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboCodigo.Text))
            {
                Int32 codigo = Convert.ToInt32(cboCodigo.Text);
                Lista.Eliminar(codigo);

                // Actualiza la interfaz gráfica después de eliminar un nodo
                if (radAscendente.Checked)
                {
                    Lista.Recorrer(grillaListaDoble);
                    Lista.Recorrer(lstListaDoble);
                    Lista.Recorrer();
                }
                else if (radDescendente.Checked)
                {
                    Lista.RecorrerDesc(grillaListaDoble);
                    Lista.RecorrerDesc(lstListaDoble);
                    Lista.Recorrer();
                }
            }
            else
            {
                MessageBox.Show("No hay código para eliminar");
            }
            btnEliminar.Enabled = false;
        }

        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigo.Text == "")
            {
                btnEliminar.Enabled = false;

            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
