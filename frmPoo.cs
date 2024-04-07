using pryPOO;
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
    public partial class frmPoo : Form
    {
        public frmPoo()
        {
            InitializeComponent();
        }

        //creo el obj
        private clsCliente objCliente = new clsCliente();
       

        private void frmPoo_Load(object sender, EventArgs e)
        {
            objCliente.Codigo = 15;
            objCliente.Nombre = "Marti p";
            objCliente.Deuda = 100;

            lblCodigo.Text = objCliente.Codigo.ToString();
            lblNombre.Text = objCliente.Nombre;
            lblDeuda.Text = objCliente.Deuda.ToString();

        }

        //Instancio los Metodos
        private void btnComprar_Click_1(object sender, EventArgs e)           
        {
            int i = int.Parse(txtImporte.Text);
            if ( objCliente.Deuda < 0)
            {
                MessageBox.Show("Saldo Insuficiente para comprar, pague sus deudas", "Error",MessageBoxButtons.OK);
                
            } else
            {
               objCliente.comprar(i);
               lblDeuda.Text = objCliente.Deuda.ToString();

            }           

        }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            int i = int.Parse(txtImporte.Text);
            
                objCliente.pagar(i);
                lblDeuda.Text = objCliente.Deuda.ToString();
            
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            verificarTexto();
        }

        private void verificarTexto()
        {            
            if (txtImporte.Text == "")
            {
                btnComprar.Enabled = false;
                btnPagar.Enabled = false;

            }else
            {
                btnComprar.Enabled = true;
                btnPagar.Enabled = true;
            }
        }
            
    }
}
