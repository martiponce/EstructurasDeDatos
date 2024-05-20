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
    public partial class frmOperacionesBaseDeDatos : Form
    {
        public frmOperacionesBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDeDatos objBD = new clsBaseDeDatos();

        private void frmOperacionesBaseDeDatos_Load(object sender, EventArgs e)
        {

        }

        /*
          Selecciona solo el título de los libros (TITULO) de la tabla LIBRO y 
            los ordena en orden descendente.
         */
        private void btnProyecSimple_Click(object sender, EventArgs e)
        {
            String sql = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";
            objBD.Listar(dgvBaseDaos, sql);
        }

        /*
         Selecciona los títulos (TITULO), autores (AUTOR) y el año (AÑO) de los libros de la tabla
         LIBRO, ordenándolos por el título en orden descendente.
         */
        private void btnProyecMultiAtributo_Click(object sender, EventArgs e)
        {
            String sql = "SELECT TITULO, AUTOR, AÑO " +
                "FROM LIBRO " +
                "ORDER BY TITULO DESC";
            objBD.Listar(dgvBaseDaos, sql);
        }

        /*
         Selecciona todos los registros (*) de las tablas LIBRO e IDIOMA donde el IDIDIOMA de ambas tablas coincide. 
         Esta consulta muestra información de ambas tablas en una sola vista.
         */
        private void btnProyecJuntar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM LIBRO,IDIOMA " +
                "WHERE LIBRO.IDIDIOMA = IDIOMA.IDIDIOMA";
            objBD.Listar(dgvBaseDaos, sql);
        }

        /*
         Selecciona todos los registros (*) de la tabla LIBRO donde el IDAUTOR es 2.
         */
        private void bnSelecSimple_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM LIBRO WHERE IDAUTOR = 2 ";
            objBD.Listar(dgvBaseDaos, sql);
        }

        /*
         Selecciona todos los registros (*) de la tabla LIBRO donde el IDAUTOR es 2 y el IDIDIOMA es 3.
         */
        private void btnSelecMuliAributo_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM LIBRO " +
               "WHERE IDAUTOR = 2 AND IDIDIOMA = 3";
            objBD.Listar(dgvBaseDaos, sql);
        }

        /*
         Realiza una subconsulta que selecciona todos los libros (*) de la tabla LIBRO donde el IDIDIOMA es mayor que 5.
         Luego, sobre el resultado de esta subconsulta, selecciona aquellos registros donde el IDAUTOR es mayor que 10.
         */
        private void btnSelecConvo_Click(object sender, EventArgs e)
        {
            String sql = "SELECT *  FROM" +
                "(SELECT * FROM LIBRO AS T1 WHERE T1.IDIDIOMA > 5) " +
                "AS T2 WHERE T2.IDAUTOR > 10";

            objBD.Listar(dgvBaseDaos, sql);
        }

        /*
         Selecciona todos los registros (*) de la tabla LIBRO donde el IDAUTOR es 2, 5 o 3, combinando los resultados 
         de las tres consultas mediante la operación UNION.
         */
        private void btnUnion_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM LIBRO WHERE IDAUTOR = 2 " +
                "UNION " +
                "SELECT * FROM LIBRO WHERE IDAUTOR = 5 " +
                "UNION " +
                "SELECT * FROM LIBRO WHERE IDAUTOR = 3";
            objBD.Listar(dgvBaseDaos, sql);
        }

        /*
         Selecciona todos los registros (*) de la tabla LIBRO donde el IDIDIOMA está en la lista de IDIDIOMA distintos
         obtenidos de una subconsulta que selecciona IDIDIOMA menor que 5.
         */
        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * " +
                "FROM LIBRO " +
                "WHERE IDIDIOMA IN " +
                "(SELECT DISTINCT IDIDIOMA FROM LIBRO WHERE IDIDIOMA < 5)";
               
            objBD.Listar(dgvBaseDaos, sql);

        }

        /*
         Selecciona todos los registros (*) de la tabla LIBRO donde el IDIDIOMA no está en la lista de IDIDIOMA distintos obtenidos 
         de una subconsulta que selecciona IDIDIOMA menor que 5.
         */
        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * " +
                "FROM LIBRO " +
                "WHERE IDIDIOMA  NOT IN " +
                "(SELECT DISTINCT IDIDIOMA FROM LIBRO WHERE IDIDIOMA < 5)";

            objBD.Listar(dgvBaseDaos, sql);
        }
    }
}
