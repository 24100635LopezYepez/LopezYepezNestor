namespace TEC_08_Merge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chrTecla = "";
            int intDato = 0;
            Random rdmNum = new Random(); //Para llenar datos
            do
            {
                Console.Clear();
                int[] miArreglo = new int[rdmNum.Next(5, 16)]; //Asigna un tamaño aleatorio para el arreglo
                int[] nuevoArreglo = new int[miArreglo.Length];
                //Llenar el arreglo de dato nuevos
                for (int x = 0; x < miArreglo.Length; x++)
                {
                    intDato = rdmNum.Next(0, 101);
                    miArreglo[x] = intDato;
                }
                Console.Write(" - - - - - - - - - - ARREGLO ORIGINAL - - - - - - - - - - \n \n [");//Se escribe el arreglo desordenado, empezando en [ y terminando en ]
                for (int y = 0; y < miArreglo.Length; y++)
                {
                    if (y < miArreglo.Length - 1) Console.Write(miArreglo[y] + ", "); //Decisión para escribir el arreglo de manera mas limpia
                    else Console.Write(miArreglo[y]);
                }
                Console.Write("] \n \n \n - - - - - - - - ARREGLO ORDENADO (DE TIPO MERGE) - - - - - - - - \n \n [");
                nuevoArreglo = MergeSort(miArreglo);

                for (int i = 0; i < nuevoArreglo.Length; i++)
                {
                    if (i < nuevoArreglo.Length - 1) Console.Write(nuevoArreglo[i] + ", "); //Decisión para escribir el arreglo de manera mas limpia
                    else Console.Write(nuevoArreglo[i]);
                }
                Console.Write("] \n \n - - - - - - - - - - - - - - - - - - - - \n > Presiona la tecla ''R'' para realizarlo de nuevo, presiona cualquier otra para salir. \n");
                chrTecla = Console.ReadLine();
            } while (chrTecla == "R");
        }
        public static int[] MergeSort(int[] Arreglo) //Metodo principal
        {
            //Utiliza recursión al final, dividiendo el arreglo del parametro para hacerlo.
            if (Arreglo.Length == 1) //Si el arreglo es de 1, regresarlo como está.
            {
                return Arreglo;
            }
            else //Si no, hacer el proceso de ordenar.
            {
                //Se asignan la parte izquierda, derecha y el punto medio a partir.
                int ptMedio = Arreglo.Length / 2;
                int[] Izquierdo = new int[ptMedio];
                int[] Derecho = new int[Arreglo.Length - ptMedio];
                //Se llenan dichas partes con los datos del arreglo a ordenar.
                for (int i = 0; i < ptMedio; i++)
                {
                    Izquierdo[i] = Arreglo[i];
                }
                for (int i = ptMedio; i < Arreglo.Length; i++)
                {
                    Derecho[i - ptMedio] = Arreglo[i];
                }
                //Recursión en uso.
                int[] mslzquierdo = MergeSort(Izquierdo);
                int[] msDerecho = MergeSort(Derecho);
                //Regresa el arreglo ya ordenado, unido por otro metodo que combinara cada uno de los separados.
                return Union(mslzquierdo, msDerecho);
            }
        }

        public static int[] Union(int[] arrIzquierdo, int[] arrDerecho) //Método para unir cada uno de ellos.
        {
            //Aignamos un arreglo resultante de la union de las partes, e indices para cada unos de ellos.
            int[] arrResultado = new int[arrIzquierdo.Length + arrDerecho.Length];
            int i = 0; int j = 0; int k = 0;
            while (i < arrIzquierdo.Length && j < arrDerecho.Length)
            {
                if (arrIzquierdo[i] < arrDerecho[j]) arrResultado[k++] = arrIzquierdo[i++]; 
                else arrResultado[k++] = arrDerecho[j++];
            }
            //Se llenan el resto de los arreglos
            while (j < arrDerecho.Length)
            { arrResultado[k++] = arrDerecho[j++]; }
            while (i < arrIzquierdo.Length)
            { arrResultado[k++] = arrIzquierdo[i++]; }
            //Se regresa el arreglo.
            return arrResultado;
        }
    }
}