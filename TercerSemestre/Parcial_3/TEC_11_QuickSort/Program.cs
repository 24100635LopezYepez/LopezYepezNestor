namespace TEC_11_QuickSort
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
                Console.Write(" - - - - - - - - - - - - - - - ARREGLO ORIGINAL - - - - - - - - - - - - - - - - \n \n [");//Se escribe el arreglo desordenado, empezando en [ y terminando en ]
                for (int y = 0; y < miArreglo.Length; y++)
                {
                    if (y < miArreglo.Length - 1) Console.Write(miArreglo[y] + ", "); //Decisión para escribir el arreglo de manera mas limpia
                    else Console.Write(miArreglo[y]);
                }
                Console.Write("] \n \n \n - - - - - - - - - - - ARREGLO ORDENADO (DE TIPO RÁPIDO) - - - - - - - - - - - \n \n [");
                nuevoArreglo = QuickSort(miArreglo, 0, miArreglo.Length-1);

                for (int i = 0; i < nuevoArreglo.Length; i++)
                {
                    if (i < nuevoArreglo.Length - 1) Console.Write(nuevoArreglo[i] + ", "); //Decisión para escribir el arreglo de manera mas limpia
                    else Console.Write(nuevoArreglo[i]);
                }
                Console.Write("] \n \n - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \n > Presiona la tecla ''R'' para realizarlo de nuevo, presiona cualquier otra para salir. \n");
                chrTecla = Console.ReadLine();
            } while (chrTecla == "R");
        }

        public static int[] QuickSort(int[] Arreglo, int Inicio, int Final)
        {
            if (Inicio < Final)
            {
                int Pivote = Dividir(Arreglo, Inicio, Final);
                QuickSort(Arreglo, Inicio, Pivote - 1);
                QuickSort(Arreglo, Pivote + 1, Final);
            }
            return Arreglo;
        }

        public static int Dividir(int[] Arreglo, int Inicio, int Final)
        {
            int Pivote = Arreglo[Final];
            int Posicion = Inicio - 1;
            for (int j = Inicio; j <= Final - 1; j++)
            {
                if (Arreglo[j] < Pivote)
                {
                    Posicion++;
                    Cambiar(Arreglo, Posicion, j);
                }
            }
            Cambiar(Arreglo, Posicion + 1, Final);
            return Posicion + 1;
        }

        public static void Cambiar(int[] Arreglo, int a, int b)
        {
            int Temporal = Arreglo[a];
            Arreglo[a] = Arreglo[b];
            Arreglo[b] = Temporal;
            return;
        }
    }
}
