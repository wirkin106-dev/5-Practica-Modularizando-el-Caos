using System;

namespace ValidadorAcceso_controlado
{
    class Program
    {
        // la funcioon del  void esque (no retorna nada, solo imprime)
        static void ValidarEdad(int edad)
        {
            if (edad < 18)
            {
                Console.WriteLine("Acceso Denegado");
            }
            else
            {
                Console.WriteLine("Bienvenido");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad:");
            int edad = int.Parse(Console.ReadLine());

            ValidarEdad(edad);
        }
    }
}