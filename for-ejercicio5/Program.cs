using System;

namespace for_ejercicio5
{
     class Program
     {
          static void Main(string[] args)
          {
               //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

               int n, max = 0, min = 0;
               bool bpar = false, bimpar = false;

               for (int x = 0; x < 20; x++)
               {
                    Console.WriteLine("Ingrese un numero:");
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                         if (!bpar)
                         {
                              max = n;
                              bpar = true;
                         }
                         else if (n > max)
                         {
                              max = n;
                         }
                    }
                    else if (!bimpar)
                    {
                         min = n;
                         bimpar = true;
                    }
                    else if (n < min)
                    {
                         min = n;
                    }
               }

               Console.WriteLine("El maximo de los pares es: " + max);
               Console.WriteLine("El minimo de los impares es: " + min);
          }
     }
}
