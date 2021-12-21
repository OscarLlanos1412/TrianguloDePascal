using System;

namespace TrianguloPascal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                int bloques = 0;
                //ARREGLO PRINCIPAL
                int[] arreglo = new int[1];
                Console.WriteLine("Ingrese el numero de bloques: ");
                bloques = Convert.ToInt16(Console.ReadLine());

                //Se recorre la vble bloque que es el tamaño del triangulo
                for (int i = 1; i <= bloques; i++)
                {
                    //Se crea el arreglo pascal para 
                    int[] pascal = new int[i];

                    //Genera espacios de acuerdo el tamaño del triangulo
                    for (int j = bloques; j > i; j--)
                    {
                        Console.Write(" ");
                    }

                    //
                    for (int k = 0; k < i; k++)
                    {
                        /*Comprueba si la vble k es igual a 0 y agrega al arreglo
                         de lo contrario este sumara el valor de una posicion con otra
                        e imprime el triangulo*/
                        if (k == 0 || k == (i - 1))
                        {
                            pascal[k] = 1;
                        }
                        else
                        {
                            pascal[k] = arreglo[k] + arreglo[k - 1];
                        }
                        //Impresión de partes del triangúlo
                        Console.Write("[" + pascal[k] + "]");
                    }
                    //Agrega los valores al arreglo principal 
                    arreglo = pascal;

                    //Genera los saltos de linea cada vez que imprime un bloque
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("No puede digitar letras");
            }
        }
    }
}
