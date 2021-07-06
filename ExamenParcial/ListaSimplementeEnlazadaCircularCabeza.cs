using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial
{
    class ListaSimplementeEnlazadaCircularCabeza
    {
        private Nodo primero;
        private Nodo ultimo;
        private NodoCabeza cabeza;
       
        public ListaSimplementeEnlazadaCircularCabeza()
        {
            primero = null;
            ultimo = null;
            
        }
        public Nodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public NodoCabeza Cabeza
        {
            get { return cabeza; }
            set { cabeza = value; }
        }

        public Nodo Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

         public bool Vacia()
    {
            if (primero == null)
                return true;
            else
                return false;
    }

    public void InsertarOrdenado(int info)
    {
            Nodo p, r, q;

            if (Vacia())
                primero = new Nodo(info, null);
            else if (info < primero.Info)
            {
                p = new Nodo(info, primero);
                primero = p;
            }
            else
            {
                r = primero;
                q = primero.Enlace;
                while (q != null && info > q.Info)
                {
                    r = q;
                    q = q.Enlace;
                }
                if (q != null)
                {
                    p = new Nodo(info, q);
                    r.Enlace = p;
                }
                else
                {
                    p = new Nodo(info, null);
                    r.Enlace = p;
                }
            }
        }
    }
}
