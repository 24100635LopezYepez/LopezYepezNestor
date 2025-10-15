namespace TEC_04b_Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strCadena = "", strCadenaInv = "";
            char charCaracter = ' ', charPalindromo = ' ';

            Console.WriteLine(" - - - - - - - - - - - - PALINDROMO E INVERTIDA - - - - - - - - - - - - \n");
            Console.Write("Introduce la palabra a invertir (y checar su palindromo): ");
            strCadena = Console.ReadLine();

            Console.WriteLine("Palabra: " + strCadena + " - Núm. de Caractéres: " + strCadena.Length);

            Pila<char> stkPila = new Pila<char>(strCadena.Length);
            for (int i = 0; i < stkPila.Max; i++) 
            {
                charCaracter = strCadena[i];
                stkPila.Push(charCaracter);
            }

            while(stkPila.Tope > 0) 
            {
                charPalindromo = stkPila.Pop();
                strCadenaInv = strCadenaInv + charPalindromo;
            }
            Console.WriteLine("\n Palabra Invertida: " + strCadenaInv);

            if (String.Equals(strCadena, strCadenaInv, StringComparison.OrdinalIgnoreCase))
            { Console.WriteLine(strCadena + " es palindromo"); }
            else { Console.WriteLine(strCadena + " no es palindromo"); }
            
            Console.ReadKey();
        }
    }
}

