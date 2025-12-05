namespace TEC_12_Insercion
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
                nuevoArreglo = Insercion(miArreglo);

                for (int i = 0; i < nuevoArreglo.Length; i++)
                {
                    if (i < nuevoArreglo.Length - 1) Console.Write(nuevoArreglo[i] + ", "); //Decisión para escribir el arreglo de manera mas limpia
                    else Console.Write(nuevoArreglo[i]);
                }
                Console.Write("] \n \n - - - - - - - - - - - - - - - - - - - - \n > Presiona la tecla ''R'' para realizarlo de nuevo, presiona cualquier otra para salir. \n");
                chrTecla = Console.ReadLine();
            } while (chrTecla == "R");
        }
        public static int[] Insercion(int[] unArreglo)
        {
            for (int i = 1; i < unArreglo.Length; i++)
            {
                int Llave = unArreglo[i];
                int j = i - 1;
                while (unArreglo[j] > Llave && j > -1)
                {
                    unArreglo[j + 1] = unArreglo[j];
                    if(j!=0) j = j - 1;
                }
                unArreglo[j + 1] = Llave;
            }
            return unArreglo;
        }
    }
}
