using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TEC_05_XML
{
    internal class Program
    {
        public class XmlSyntaxChecker
        {
            /// <summary>
            /// Verifica si una cadena XML está "bien formada" usando una pila
            /// para comprobar el correcto anidamiento de las etiquetas.
            /// </summary>
            /// <param name="xmlString">La cadena XML a analizar.</param>
            /// <returns>True si el XML está bien formado, False en caso contrario.</returns>
            public static bool IsWellFormedByStack(string xmlString)
            {
                // 1. Pila para almacenar las etiquetas de apertura
                Stack<string> tagStack = new Stack<string>();

                // Expresión regular para encontrar etiquetas: <tag> o </tag> o <tag/>
                // Captura el nombre de la etiqueta.
                // Opción 1: Etiqueta de apertura con o sin atributos: <nombreTag ...>
                // Opción 2: Etiqueta de cierre: </nombreTag>
                // Opción 3: Etiqueta de cierre automático: <nombreTag .../>
                string pattern = @"<\s*(\w+)[^>]?>|<\/\s(\w+)\s*>|<\s*(\w+)[^>]?\/\s>";
                MatchCollection matches = Regex.Matches(xmlString, pattern);

                foreach (Match match in matches)
                {
                    // El nombre de la etiqueta puede estar en el grupo 1 (apertura), 2 (cierre) o 3 (autocierre).
                    string openTag = match.Groups[1].Value;
                    string closeTag = match.Groups[2].Value;
                    string selfClosingTag = match.Groups[3].Value;

                    if (!string.IsNullOrEmpty(openTag))
                    {
                        // *CASO 1: Etiqueta de Apertura (<tag>)*
                        tagStack.Push(openTag);
                    }
                    else if (!string.IsNullOrEmpty(closeTag))
                    {
                        // *CASO 2: Etiqueta de Cierre (</tag>)*

                        // Si la pila está vacía, tenemos una etiqueta de cierre sin una de apertura correspondiente.
                        if (tagStack.Count == 0)
                        {
                            Console.WriteLine($"Error: Etiqueta de cierre inesperada '</{closeTag}>'.");
                            return false;
                        }

                        // Sacamos el último elemento (la etiqueta de apertura esperada)
                        string lastOpenTag = tagStack.Pop();

                        // Comprobamos si coincide con la etiqueta de cierre actual
                        if (!lastOpenTag.Equals(closeTag, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Error: Etiqueta de cierre '</{closeTag}>' no coincide con la etiqueta de apertura '{lastOpenTag}'.");
                            return false;
                        }
                    }
                    else if (!string.IsNullOrEmpty(selfClosingTag))
                    {
                        // *CASO 3: Etiqueta de Autocierre (<tag/>)*
                        // Estas etiquetas no afectan el balance de la pila, solo las ignoramos después de encontrarlas.
                        continue;
                    }
                }

                // 2. Comprobación final
                // Si la pila no está vacía al final, significa que quedan etiquetas de apertura sin cerrar.
                if (tagStack.Count > 0)
                {
                    Console.WriteLine($"Error: Quedan {tagStack.Count} etiquetas de apertura sin cerrar. Última etiqueta abierta: '{tagStack.Peek()}'");
                    return false;
                }

                // Si el ciclo termina y la pila está vacía, el anidamiento es correcto.
                return true;
            }
            static void Main(string[] args)
            {
                // --- Ejemplos de prueba ---

                // 1. Bien Formado
                string xml1 = "<root><data id=\"1\"><item/></data></root>";
                Console.WriteLine($"XML 1 (Correcto): {IsWellFormedByStack(xml1)}");

                // 2. Mal Formado (Etiqueta sin cerrar)
                string xml2 = "<root><data>";
                Console.WriteLine($"XML 2 (Fallo - Sin cerrar): {IsWellFormedByStack(xml2)}");

                // 3. Mal Formado (Anidamiento incorrecto)
                string xml3 = "<parent><child></parent></child>";
                Console.WriteLine($"XML 3 (Fallo - Anidamiento): {IsWellFormedByStack(xml3)}");

                // 4. Mal Formado (Etiqueta de cierre inesperada)
                string xml4 = "<root></extra></root>";
                Console.WriteLine($"XML 4 (Fallo - Cierre inesperado): {IsWellFormedByStack(xml4)}");

                // 5. Bien Formado (con atributos y autocierre)
                string xml5 = "<doc vers=\"1.0\"><elem atb='val'/></doc>";
                Console.WriteLine($"XML 5 (Correcto - Atributos y Autocierre): {IsWellFormedByStack(xml5)}");

                Console.ReadKey();
            }
        }
    }
}
