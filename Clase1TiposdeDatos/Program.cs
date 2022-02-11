using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1TiposdeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 0;
            int num2= 2, num3= 45;
            long larga = 25412;
            double doble = 23.89d; // 15,455877 caracteres
            float flotante = 14.122151512f; // 15,16 decimales
            decimal decimales = 15.233m; // decimales formato con m
            //int i = 0;
            //i--;
            //var variable = doble + doble;
            //Console.WriteLine("El valor de variable es: " + variable + " y su tipo es: " + variable.GetType());
            //Console.WriteLine(i);
            //Console.ReadLine();

            int[] arreglo = new int[10];
            int[] arreglo1 = new int[] { 10, 15, 12 };
            int[] arreglo2 = { 15, 12 };

            String[] banda = new String[] { "Paul", "George", "John", "Ringo" };
            String[] banda2 = new String[] { "Billie Joe", "Sean Hughes", "Tre", "Mike Dirnt" };
            int[] notas = new int[] { 100, 80, 75, 40 };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(banda[i]);
            }

            int indice = 0;
            while (indice<4)
            {
                Console.WriteLine(banda[indice]);
                indice++;
            }

            for (int i = 3; i >=0 ; i--)
            {
                Console.WriteLine(banda2[i]);
            }
            int ban = 0;
            float promedio = 0;
            Console.WriteLine(" Estudiante           Notas");
            Console.WriteLine("----------------------------");
            while (ban < banda.Length)
            {
                promedio += notas[ban];
                Console.WriteLine("{0}                  {1}", banda[ban],notas[ban]);
                //Console.WriteLine(banda[ban] + "     " + notas[ban]);
                ban++;
            }

           
            
            promedio /= notas.Length;
            Console.WriteLine("El promedio del grupo es: "+promedio);

            ban = 0;

            while (ban < banda.Length)
            {
                if (notas[ban] > promedio)
                {
                    Console.WriteLine("{0} El Estudiante tiene una nota mayor al promedio", banda[ban]);
                }
                else
                {
                    Console.WriteLine("{0} El Estudiante no llego a la nota promedio",banda[ban]);
                }
                ban++;
            }

            int[,] matriz = new int[5,5];
            int contar = 0;
            int sumacol = 0;
            int sumaFila = 0;
            int sumaDiagonalUno = 0;
            int sumaDiagonalDos = 0;
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    matriz[fila, columna] =contar+=2;
                    //Console.Write($"   { matriz[fila, columna]}");
                    Console.Write(" " + matriz[fila, columna]);

                    if (columna == 1)
                    {
                        sumacol += matriz[fila, columna];
                    }
                    if (fila == 2)
                    {
                        sumaFila += matriz[fila,columna];
                    }
                    if (fila == columna)
                    {
                        sumaDiagonalUno += matriz[fila, columna];
                    }
                    if (fila + columna == 4)
                    {
                        sumaDiagonalDos += matriz[fila, columna];
                    }
                    
                }
                Console.WriteLine();

            }
            Console.WriteLine("La suma de la columna 2 es: " + sumacol);
            Console.WriteLine("La suma de la Fila 3 es: " + sumaFila);
            Console.WriteLine("La suma de la Diagonal uno es: " + sumaDiagonalUno);
            Console.WriteLine("La suma de la Diagonal dos es: " + sumaDiagonalDos);

            Console.ReadLine();

        }
        
    }
}
