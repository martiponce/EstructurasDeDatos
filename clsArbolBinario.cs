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
                clsNodo NodoPadre = Raiz; //ant
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

        
        public void Recorrer (ComboBox Combo)
        {
             Combo.Items.Clear();
            InOrdenAsc(Combo,Raiz);
        }

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
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        //InOrdenAsc
        public void InOrdenAsc(ComboBox cbo,clsNodo R)
        {
            cbo.Items.Add(R.Codigo);
            if(R.Derecho != null) InOrdenAsc(cbo, R.Derecho);
        }
        private void InOrdenAsc (DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        
        //Falta Imprimir

        //PreOrden
        public void Recorrer (TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(nodoPadre);
            PreOrden(Raiz, nodoPadre);
            tree.ExpandAll();

        }
        public void PreOrden (clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, nodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, nodoPadre);
        }
    }
}
