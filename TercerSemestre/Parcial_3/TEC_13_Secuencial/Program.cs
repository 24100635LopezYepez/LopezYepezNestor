namespace TEC_13_Secuencial
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
                int num = 0;
                //Llenar el arreglo de dato nuevos
                for (int x = 0; x < miArreglo.Length; x++)
                {
                    intDato = rdmNum.Next(0, 101);
                    miArreglo[x] = intDato;
                }
                Console.Write(" - - - - - - - - - Busqueda secuencial - - - - - - - - - \n \n Arreglo: [");//Se escribe el arreglo desordenado, empezando en [ y terminando en ]
                for (int y = 0; y < miArreglo.Length; y++)
                {
                    if (y < miArreglo.Length - 1) Console.Write(miArreglo[y] + ", "); //Decisión para escribir el arreglo de manera mas limpia
                    else Console.Write(miArreglo[y]);
                }

                try
                {
                    Console.Write("] \n ¿Que desea buscar? - ");
                    num = int.Parse(Console.ReadLine());
                } catch (Exception err) 
                { Console.WriteLine("\n Error, usa un numero entero para tu busqueda. \n"); }

                if (Secuencial(miArreglo, num) != -1)
                    Console.Write("Se encontró el numero " + num + " en la posición: " + Secuencial(miArreglo, num));
                else Console.Write("No se encontró el valor pedido");

                Console.Write("\n > Presiona la tecla ''R'' para buscar de nuevo, presiona cualquier otra para salir. \n");
                chrTecla = Console.ReadLine();
            } while (chrTecla == "R");
        }
        static int Secuencial(int[] Arreglo, int valor) 
        {
            int i = 0;
            while(i < Arreglo.Length) 
            {
                if (Arreglo[i] == valor) return i;
                i++;
            }
            return -1;
        }
    }
}
