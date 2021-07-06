using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    class NodoArbol
    {
        private int info;
        private NodoDoble enlaceIzquierdo;
        private NodoDoble enlaceDerecho;


        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public NodoDoble EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }
        public NodoDoble EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
    }
}
