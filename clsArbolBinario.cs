using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonceDeLeonMartinaEstrucDatos
{

    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }

        public void Eliminar(int codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private clsNodo EliminarRecursivo(clsNodo nodoActual, int codigo)
        {
            if (nodoActual == null)
            {
                return nodoActual;
            }

            if (codigo < nodoActual.Codigo)
            {
                nodoActual.Izquierdo = EliminarRecursivo(nodoActual.Izquierdo, codigo);
            }
            else if (codigo > nodoActual.Codigo)
            {
                nodoActual.Derecho = EliminarRecursivo(nodoActual.Derecho, codigo);
            }
            else
            {
                if (nodoActual.Izquierdo == null)
                {
                    return nodoActual.Derecho;
                }
                else if (nodoActual.Derecho == null)
                {
                    return nodoActual.Izquierdo;
                }

                nodoActual.Codigo = ObtenerCodigoMinimo(nodoActual.Derecho);
                nodoActual.Derecho = EliminarRecursivo(nodoActual.Derecho, nodoActual.Codigo);
            }

            return nodoActual;
        }

        private int ObtenerCodigoMinimo(clsNodo nodo)
        {
            int minimo = nodo.Codigo;
            while (nodo.Izquierdo != null)
            {
                minimo = nodo.Izquierdo.Codigo;
                nodo = nodo.Izquierdo;
            }
            return minimo;
        }

        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        //imprimir
        public void Recorrer()
        {
            clsNodo aux = Raiz;
            StreamWriter AD = new StreamWriter("ArbolBinario.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código;Nombre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }

        // InOrdenAsc
        public void InOrdenAsc(ComboBox cbo, clsNodo R)
        {
            if (R != null)
            {
                InOrdenAsc(cbo, R.Izquierdo);
                cbo.Items.Add(R.Codigo);
                InOrdenAsc(cbo, R.Derecho);
            }
        }

        public void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        //InOrdenDesc
        public void InOrdenDesc(ComboBox cbo, clsNodo R)
        {
            if (R != null)
            {
                InOrdenDesc(cbo, R.Derecho); // Recorremos primero el subárbol derecho
                cbo.Items.Add(R.Codigo); // Agregamos el código al combo
                InOrdenDesc(cbo, R.Izquierdo); // Luego recorremos el subárbol izquierdo
            }
        }

        public void CargarGrillaInOrdenDesc(DataGridView dgv)
        {
            dgv.Rows.Clear();
            CargarGrillaInOrdenDescRec(dgv, Raiz);
        }

        private void CargarGrillaInOrdenDescRec(DataGridView dgv, clsNodo R)
        {
            if (R != null)
            {
                CargarGrillaInOrdenDescRec(dgv, R.Derecho); // Cargamos primero el subárbol derecho
                dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite); // Agregamos el nodo actual a la grilla
                CargarGrillaInOrdenDescRec(dgv, R.Izquierdo); // Luego cargamos el subárbol izquierdo
            }
        }

        // PreOrden
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(nodoPadre);
            PreOrden(Raiz, nodoPadre);
            tree.ExpandAll();
        }

        public void PreOrden(ComboBox cbo, clsNodo R)
        {
            if (R != null)
            {
                cbo.Items.Add(R.Codigo);
                PreOrden(cbo, R.Izquierdo);
                PreOrden(cbo, R.Derecho);
            }
        }

        public void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, nodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, nodoPadre);
        }

        // PostOrden
        public void PostOrden(ComboBox cbo, clsNodo R)
        {
            if (R != null)
            {
                PostOrden(cbo, R.Izquierdo);
                PostOrden(cbo, R.Derecho);
                cbo.Items.Add(R.Codigo);
            }
        }

        // Método para cargar el TreeView en pre-orden
        public void CargarTreeView(TreeView treeView)
        {
            treeView.Nodes.Clear();
            CargarTreeViewPreOrden(treeView.Nodes, Raiz);
        }

        public void CargarTreeViewPreOrden(TreeNodeCollection nodes, clsNodo R)
        {
            if (R != null)
            {
                TreeNode node = nodes.Add(R.Codigo.ToString());
                CargarTreeViewPreOrden(node.Nodes, R.Izquierdo);
                CargarTreeViewPreOrden(node.Nodes, R.Derecho);
            }
        }

        // Método para cargar la grilla en orden ascendente
        public void CargarGrillaInOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            CargarGrillaInOrdenRec(dgv, Raiz);
        }

        public void CargarGrillaInOrdenRec(DataGridView dgv, clsNodo R)
        {
            if (R != null)
            {
                CargarGrillaInOrdenRec(dgv, R.Izquierdo);
                dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                CargarGrillaInOrdenRec(dgv, R.Derecho);
            }
        }

        // Método para cargar el combo en orden ascendente
        public void CargarComboInOrden(ComboBox cbo)
        {
            cbo.Items.Clear();
            CargarComboInOrdenRec(cbo, Raiz);
        }

        public void CargarComboInOrdenRec(ComboBox cbo, clsNodo R)
        {
            if (R != null)
            {
                CargarComboInOrdenRec(cbo, R.Izquierdo);
                cbo.Items.Add(R.Codigo);
                CargarComboInOrdenRec(cbo, R.Derecho);
            }
        }

        // Cargar grilla en preorden
        public void CargarGrillaPreOrden(DataGridView dgv)
        {
            dgv.Rows.Clear();
            CargarGrillaPreOrdenRec(dgv, Raiz);
        }

        private void CargarGrillaPreOrdenRec(DataGridView dgv, clsNodo R)
        {
            if (R != null)
            {
                dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite); // Agrega el nodo actual a la grilla
                CargarGrillaPreOrdenRec(dgv, R.Izquierdo); // Recorre el subárbol izquierdo
                CargarGrillaPreOrdenRec(dgv, R.Derecho);   // Recorre el subárbol derecho
            }
        }

        // Cargar grilla en postorden
        public void CargarGrillaPostOrden(DataGridView dgv)
        {
            dgv.Rows.Clear(); // Limpiamos la grilla antes de cargar

            // Llamamos al método recursivo que recorre en postorden y carga la grilla
            CargarGrillaPostOrdenRec(dgv, Raiz);
        }

        private void CargarGrillaPostOrdenRec(DataGridView dgv, clsNodo R)
        {
            if (R != null)
            {
                // Recorremos primero el subárbol izquierdo
                CargarGrillaPostOrdenRec(dgv, R.Izquierdo);

                // Luego recorremos el subárbol derecho
                CargarGrillaPostOrdenRec(dgv, R.Derecho);

                // Agregamos el nodo actual a la grilla
                dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            }
        }

        //EQUILIBRAR (modifique lo q paso la profe)

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i += 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        private void GrabarVectorInOrden (clsNodo NodoPadre, Int32 codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i += 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
    }

}
