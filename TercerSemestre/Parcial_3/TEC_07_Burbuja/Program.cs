namespace TEC_07_Burbuja
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
                Console.Write("] \n \n \n - - - - - - - - ARREGLO ORDENADO (DE TIPO BURBUJA) - - - - - - - - \n \n [");


                for (int i = 0; i < miArreglo.Length - 1; i++)
                {
                    for (int j = miArreglo.Length - 1; j > i; j--)
                    {
                        if (miArreglo[j] < miArreglo[j - 1])
                        {
                            int intTemporal = miArreglo[j];
                            miArreglo[j] = miArreglo[j - 1];
                            miArreglo[j - 1] = intTemporal;
                        }
                    }
                }
                for (int i = 0; i < miArreglo.Length; i++)
                {
                    if (i < miArreglo.Length - 1) Console.Write(miArreglo[i] + ", "); //Decisión para escribir el arreglo de manera mas limpia
                    else Console.Write(miArreglo[i]);
                }
                Console.Write("] \n \n - - - - - - - - - - - - - - - - - - - - \n > Presiona la tecla ''R'' para realizarlo de nuevo, presiona cualquier otra para salir. \n");
                chrTecla = Console.ReadLine();
            } while (chrTecla == "R");
        }
    }
}