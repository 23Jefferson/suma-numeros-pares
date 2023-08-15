using System;

namespace SumaNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Suma de Números Pares");
            Console.WriteLine("===============================");

            Console.Write("Ingrese el rango mínimo: ");
            int minimo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el rango máximo: ");
            int maximo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de números pares a sumar: ");
            int cantidadNumerosPares = int.Parse(Console.ReadLine());

            int suma = CalcularSumaNumerosPares(minimo, maximo, cantidadNumerosPares);

            Console.WriteLine($"La suma de los primeros {cantidadNumerosPares} números pares entre {minimo} y {maximo} es: {suma}");
        }

        static int CalcularSumaNumerosPares(int min, int max, int cantidad)
        {
            int suma = 0;
            int contador = 0;

            for (int num = min; num <= max; num++)
            {
                if (num % 2 == 0)
                {
                    suma += num;
                    contador++;

                    if (contador == cantidad)
                    {
                        break;
                    }
                }
            }

            return suma;
        }
    }
}