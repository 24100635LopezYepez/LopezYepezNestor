namespace TEC_04a_Sintaxis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alta y asignacion de valores nulos
            string strCadena = "";
            bool blnValido = false, blnCorrer = false;
            char chrUltimoAbierto = ' ';
            do
            {
                Console.WriteLine(" - - - - - - - - - - - - SINTAXIS - - - - - - - - - - - - \n");
                Console.Write("Introduce la operación a comprobar su validez: ");
                strCadena = Console.ReadLine();

                if (strCadena.Contains('(') || strCadena.Contains('[') || strCadena.Contains('{') || strCadena.Contains(')') || strCadena.Contains(']') || strCadena.Contains('}'))
                {
                    Pila<char> stkParentesis = new Pila<char>(strCadena.Length);
                    foreach (char charCaracter in strCadena)
                    {
                        if (charCaracter == '{' || charCaracter == '[' || charCaracter == '(')
                        {
                            stkParentesis.Push(charCaracter);
                        }
                        else if (charCaracter == '}' || charCaracter == ']' || charCaracter == ')')
                        {
                            if (!stkParentesis.Vacia)
                            {
                                blnValido = true;
                            }

                            chrUltimoAbierto = stkParentesis.Pop();
                            if (Coinciden(chrUltimoAbierto, charCaracter))
                            {
                                blnValido = true;
                            }
                        }
                    }

                    if (stkParentesis.Vacia)
                    {
                        blnValido = true;
                    }
                }
                else
                {
                    blnValido = true;
                }
                Console.WriteLine("\n - - - - - - VERIFICACIÓN - - - - - - -");
                if (blnValido) 
                { 
                    Console.WriteLine("\n" + strCadena + " es valido."); 
                }
                else
                {
                    Console.WriteLine("\n" + strCadena + " NO es valido.");
                }

                Console.WriteLine("\n - - - - - - - - - - - - - - - - - - - - - \n Teclea 's' para salir del programa. ");
                string strConfirmar = Console.ReadLine();
                if (string.Equals(strConfirmar, "s") || string.Equals(strConfirmar, "S"))
                {
                    blnCorrer = false;
                }
                else
                {
                    blnCorrer = true;
                }
            } while (blnCorrer == true);
        }
        private static bool Coinciden(char chrAbierto, char chrCerrado)
        {
            return (chrAbierto == '(' && chrCerrado == ')') ||
                   (chrAbierto == '[' && chrCerrado == ']') ||
                   (chrAbierto == '{' && chrCerrado == '}');
        }

    }
}
