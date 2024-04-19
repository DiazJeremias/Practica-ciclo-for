using System;

namespace for_ejercicio3
{
     class Program
     {
          static void Main(string[] args)
          {
               //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

               int edad;
               float promedio, acu = 0, cont = 0;

               for (int x = 0; x < 20; x++)
               {
                    Console.WriteLine("Ingrese una edad:");
                    edad = int.Parse(Console.ReadLine());

                    if (edad > 18)
                    {
                         acu += edad;
                         cont++;
                    }
               }

               promedio = acu / cont;

               Console.WriteLine("El promedio de edad de los mayores de 18 años es " + promedio.ToString("0.00"));
          }
     }
}
