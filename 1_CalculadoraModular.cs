using System;

namespace CalculadoraModular
{
    class Program
    {
        // FUUncion paRa sumar las variables
        static double Sumar(double a, double b)
        {
            return a + b;
        }

        // Función para restarlas
        static double Restar(double a, double b)
        {
            return a - b;
        }

        // Función para multiplicar
        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Función para dividir
        static double Dividir(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {Multiplicar(num1, num2)}");
            Console.WriteLine($"División: {Dividir(num1, num2)}");
        }
    }
}