using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_Pila
{
    class Pila<Tipo> where Tipo : IEquatable<Tipo>
    {
        private Nodo<Tipo> _top;

        private Nodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public Pila()
        {
            this.Top = null;
        }

        public bool Vacia
        {
            get
            {
                if (Top == null)
                    return (true);
                else
                    return (false);
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
                yield break;

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Top;

            do
            {
                yield return (nodoActual.ObjetoConDatos);
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);

            yield break;
        }

        public void Push(Tipo objeto)
        {
            Nodo<Tipo> nodoNuevo;

            if (Vacia)
            {
                nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                this.Top = nodoNuevo;
                return;
            }

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Top;

            do
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    throw new Exception("No se permiten duplicados");
                }

                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);

            nodoNuevo = new Nodo<Tipo>();
            nodoNuevo.ObjetoConDatos = objeto;
            nodoNuevo.Siguiente = this.Top;
            this.Top = nodoNuevo;
        }

        public Tipo Pop()
        {
            if (Vacia)
                throw new Exception("La pila está vacía");

            Nodo<Tipo> nodoEliminado = new Nodo<Tipo>();

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Top;

            Top = nodoActual.Siguiente;

            nodoEliminado.ObjetoConDatos = nodoActual.ObjetoConDatos;
            nodoActual = null;
            return (nodoEliminado.ObjetoConDatos);
        }

        public Tipo Pop(Tipo objeto)
        {
            if (Vacia)
                throw new Exception("La pila está vacía");

            Nodo<Tipo> nodoEliminado;

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();
            nodoActual = this.Top;
            nodoPrevio = nodoActual;

            while (nodoActual != null)
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    nodoEliminado = new Nodo<Tipo>();
                    nodoEliminado = nodoActual;

                    if (nodoActual == Top)
                    {
                        Top = nodoActual.Siguiente;
                        nodoActual = null;
                    }
                    else
                    {
                        nodoPrevio.Siguiente = nodoActual.Siguiente;
                        nodoActual = null;
                    }
                    return (nodoEliminado.ObjetoConDatos);
                }

                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
            }

            return (default(Tipo));
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            Nodo<Tipo> nodoActual = new Nodo<Tipo>();

            nodoActual = this.Top;

            while (nodoActual != null)
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return (nodoActual.ObjetoConDatos);
                }

                nodoActual = nodoActual.Siguiente;
            }

            throw new Exception("No encontrado");
        }
        public void Vaciar()
        {
            if (Vacia)
                throw new Exception("La pila está vacía");

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Top;
            Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();

            do
            {
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
                nodoPrevio = null;
            } while (nodoActual != null);

            Top = null;
        }

        ~Pila()
        {
            Vaciar();
        }
    }
}