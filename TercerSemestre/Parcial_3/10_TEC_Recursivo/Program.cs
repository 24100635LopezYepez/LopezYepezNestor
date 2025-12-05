namespace _10_TEC_Recursivo
{
    internal class Program
    {
        static void Main()
        {
            int n = 0, r = 1;
            string c = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.WriteLine(" = = = NUMERO FACTORIAL = = = \n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ingresa un numero entero para factorizar: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    r = Factorial(n);
                }
                catch (Exception err) { Console.WriteLine(err.Message); }
                Console.WriteLine("- Resultado del factor !" + n + ": " + r + " \n \n > Ingresa 'r' para reintentar, y cualquier otra para salir");
                c = Console.ReadLine();
            } while (c == "R" || c == "r");
        }
        public static int Factorial(int x) 
        {
            if (x == 1) return x;
            else return x*Factorial(x - 1);
        }
    }
}
