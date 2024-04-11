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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void vistapreviadeimpresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosAlumno frm = new frmDatosAlumno();

            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Close();
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            // Colo de la barr de menú
            MenuStrip menu = sender as MenuStrip;

            if (menu != null)
            {
                Color colorFondoBarra = Color.White; 
                e.Graphics.FillRectangle(new SolidBrush(colorFondoBarra), new Rectangle(0, 0, menu.Width, menu.Height));
            }
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Paint += menuStrip1_Paint;
           
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frm = new frmCola();

            frm.Show();
        }

        private void pOOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoo frm = new frmPoo();  
            frm.Show(); 
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frm = new frmPila();
            frm.Show();
        }

        private void seleccionartodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frm = new frmListaSimple();
            frm.Show();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frm = new frmListaDoble();    
            frm.Show(); 
        }
    }
}
    

