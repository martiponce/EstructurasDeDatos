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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void frmBaseDatosRepasoOperaciones_Load(object sender, EventArgs e)
        {

        }
        private void LlenarComboBox()
        {
            // 20 situaciones en el comb
            cboOperaciones.Items.Add("Paises sin libros");
            cboOperaciones.Items.Add("Paises con libros");
            cboOperaciones.Items.Add("Libros por autor (ID=2)");
            cboOperaciones.Items.Add("Proyección múltiple (Título, Autor, Año)");
            cboOperaciones.Items.Add("Libros en idioma (ID=1)");
            cboOperaciones.Items.Add("Libros después del 2000");
            cboOperaciones.Items.Add("Libros antes del 1990");
            cboOperaciones.Items.Add("Libros con precio mayor a 20");
            cboOperaciones.Items.Add("Libros con precio menor a 10");
            cboOperaciones.Items.Add("Autores que empiezan con 'A'");
            cboOperaciones.Items.Add("Autores que terminan con 'Z'");
            cboOperaciones.Items.Add("Títulos que contienen 'Ciencia'");
            cboOperaciones.Items.Add("Títulos que contienen 'Historia'");
            cboOperaciones.Items.Add("Libros por autores específicos (1, 3, 5)");
            cboOperaciones.Items.Add("Libros en idiomas específicos (2, 4, 6)");
            cboOperaciones.Items.Add("Libros entre 1990 y 2000");
            cboOperaciones.Items.Add("Libros con precio entre 10 y 20");
            cboOperaciones.Items.Add("Autores que no empiezan con 'J'");
            cboOperaciones.Items.Add("Títulos que no contienen 'Matemáticas'");
            cboOperaciones.Items.Add("Libros con precio < 15 y después del 2010");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos objBD = new clsBaseDeDatos();
            String sql = "SELECT * FROM LIBRO";
            switch (cboOperaciones.SelectedIndex)
            {
                case 0:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM PAIS WHERE IDPAIS NOT IN (SELECT DISTINCT IDPAIS FROM LIBRO)";
                    break;
                case 1:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM PAIS WHERE IDPAIS IN (SELECT DISTINCT IDPAIS FROM LIBRO)";
                    break;
                case 2:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE IDAUTOR = 2";
                    break;
                case 3:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT TITULO, IDAUTOR, AÑO FROM LIBRO ORDER BY TITULO DESC";
                    break;
                case 4:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE IDIDIOMA = 1";
                    break;
                case 5:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE AÑO > 2000";
                    break;
                case 6:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE AÑO < 1990";
                    break;
                case 7:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE PRECIO > 20";
                    break;
                case 8:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE PRECIO < 10";
                    break;
                case 9:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE IDAUTOR LIKE 'A%'";
                    break;
                case 10:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE IDAUTOR LIKE '%Z'";
                    break;
                case 11:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE TITULO LIKE '%Ciencia%'";
                    break;
                case 12:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE TITULO LIKE '%Historia%'";
                    break;
                case 13:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE IDAUTOR IN (1, 3, 5)";
                    break;
                case 14:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE IDIDIOMA IN (2, 4, 6)";
                    break;
                case 15:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE AÑO BETWEEN 1990 AND 2000";
                    break;
                case 16:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE PRECIO BETWEEN 10 AND 20";
                    break;
                case 17:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE IDAUTOR NOT LIKE 'J%'";
                    break;
                case 18:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE TITULO NOT LIKE '%Matemáticas%'";
                    break;
                case 19:
                    lblEnunciado.Text = cboOperaciones.Text + ": ";
                    sql = "SELECT * FROM LIBRO WHERE PRECIO < 15 AND AÑO > 2010";
                    break;
                default:
                    lblEnunciado.Text = "Seleccione una operación válida.";
                    sql = "SELECT * FROM LIBRO";
                    break;
            }

            objBD.Listar(dgvConsulta, sql);
        }
    }       
}
