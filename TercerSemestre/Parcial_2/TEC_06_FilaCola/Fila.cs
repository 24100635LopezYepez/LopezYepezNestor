using System;

namespace TEC_06_FilaCola
{
    internal class Fila<Tipo>
    {
        private readonly int intMax;
        private int intFrente;
        private int intFinal;
        private readonly Tipo[] Arreglo;

        public Fila(int intTamanio)
        {
            intMax = intTamanio;
            intFrente = -1;
            intFinal = -1;
            Arreglo = new Tipo[intMax]; //Creación del arreglo.
        }

        public int Max
        {
            get { return intMax; }
        }

        public int Frente
        {
            get { return intFrente; }
            private set { intFrente = value; }
        }
        public int Final
        {
            get { return intFinal; }
            private set { intFinal = value; }
        }

        //Método de detectar una cola llena
        private bool EstaLlena()
        {
            if (intFinal == intMax - 1) return true;
            else return false;
        }

        //Método de dectar una cola vacía.
        private bool EstaVacia()
        {
            if (intFrente == -1) return true;
            else return false;
        }

        //Método para insertar dato a una cola.
        public bool Insertar(Tipo Dato)
        {
            intFinal++;
            Arreglo[intFinal] = Dato;

            if (intFinal == 0)
            {
                intFrente = intFinal;
                return true;
            }
            else return false;
        }

        //Metodo para eliminar un dato.
        public int Eliminar()
        {
            if (EstaVacia())
                throw new Exception("La cola está vacía");

            int intVacia = intFrente;

            if (intFrente == intFinal)
            {
                // Se eliminó el último.
                intFrente = -1;
                intFinal = -1;
            }
            else intFrente++;
            return intVacia;
        }

        //Metodo de desplegar datos en pantalla.
        public string OrdenarMostrar()
        {
            string strResultado = "";
            if (!EstaVacia())
            {
                for (int i = intFrente; i <= intFinal; i++)
                {
                    strResultado = strResultado + "\n  [" + i + "] -> " + Arreglo[i].ToString() + "\n";

                }
                return strResultado;
            }
            else
            {
                return strResultado + "\n\n Frente = " + intFrente.ToString();
            }
        }

        //Método para vacíar la pila.
        public void Vaciar()
        {
            //Inicializa pila vacía 
            intFrente = -1;
            intFinal = -1;
        }

    }
}

