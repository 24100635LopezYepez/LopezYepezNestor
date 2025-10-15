namespace TEC_04b_Palindromo
{
    internal class Pila<Tipo> //Clase parametrizada para su versatilidad
    {
        private int intMax; //El tamaño del arreglo
        private int intTope; //El ultimo de la pila
        private Tipo[] Arreglo; //Para guardar los datos

        public Pila(int intTamanio) //Constructor asegurarndo que se provee el tamaño del arreglo para guardar la info.
        {
            intTope = 0;
            intMax = intTamanio;
            Arreglo = new Tipo[intMax];
        }

        public int Max
        {
            get { return intMax; }
            private set { intMax = value; }
        }

        public int Tope
        {
            get { return intTope; }
            private set { intTope = value; }
        }


        //Metodo de determinar pila llena.
        private bool EstaLlena()
        {
            if (intTope == intMax) return true;
            else return false;
        }

        //Método para determinar pila vacía.
        private bool EstaVacia()
        {
            if (intTope <= 0) return true;
            else return false;
        }

        //Método para insertar un dato en la pila.
        public bool Push(Tipo tipoDato)
        {
            if (!EstaLlena())
            {
                Arreglo[intTope] = tipoDato;
                intTope++;
                return true;
            }
            else return false;
        }

        //Método para eliminar el ultimo elemento agregado.
        public Tipo Pop()
        {
            if (!EstaVacia())
            {
                intTope--;
                return Arreglo[intTope]; // Devolver valor correcto.
            }
            else throw new Exception("La pila está vacía"); // Devuelve un "error".
            
        }

        //Mostrar datos
        public string Mostrar()
        {
            string strResultado = "";
            if (!EstaVacia())
            {
                for (int i = 0; i <= intTope; i++)
                {
                    strResultado = strResultado + "\n [" + i.ToString() + "] -> " + Arreglo[i].ToString();
                    strResultado = strResultado + "\n \n Top =" + intTope.ToString() + "\n";
                    strResultado = strResultado + "\n Max " + intMax.ToString();
                }
                return strResultado;
            }
            else
            {
                strResultado += "\n\n Pila Vacía!";
                return strResultado;
            }

        }

        //propiedad para saber si esta vacia
        public bool Vacia
        {
            get
            {
                if (intTope < 0)
                    return (true);
                else
                    return (false);
            }
        }

        public bool Buscar(Tipo busqueda)
        {
            bool blnEncontrado = false;
            if (EstaVacia()) return (false);
            else
            {
                for (int i = 0; i <= intTope; i++)
                {
                    if (Arreglo[i].Equals(busqueda)) blnEncontrado = true;
                    else blnEncontrado = false;
                }
            }
            return blnEncontrado;
        }

        public void Vaciar() //Borrar todos los datos guardados.
        {
            intTope = -1;
            intMax = 0;
            Arreglo = null;
        }

        ~Pila() //Destructor asegurandose de borrar todo.
        {
            Vaciar();
        }
    }
}
