using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial
{
    class ArbolBinario
    {
        NodoArbol raiz, p;
        NodoArbol aux = new NodoArbol();
         public void crearArbolLexicografico(int x)
        {
            if (raiz == null)
            {
                raiz = new NodoArbol();
                raiz.Info = x;
                raiz.EnlaceDerecho = null;
                raiz.EnlaceIzquierdo = null;

            }
            else
            {
                p = raiz;
                while (p != null)
                {
                    if (x < p.Info)
                    {
                        aux = p;
                        p = p.EnlaceIzquierdo;
                    }
                    else
                    {
                        if(x > p.Info)
                        {
                            aux = p;
                            p = p.EnlaceDerecho;
                        }
                    }

                }
            }
           
               
         }
    }
}
