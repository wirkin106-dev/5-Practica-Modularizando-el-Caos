using System;

namespace FormularioFlexible
{
    class Program
    {
        // 1. Función CrearPerfil
        // hobby es opcional con default "Dormir"
        static void CrearPerfil(string hobby = "Dormir")
        {
            // ✅ pide el nombre al usuario
            Console.WriteLine("Ingresa tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine($"\nPerfil creado:");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Hobby: {hobby}");
            Console.WriteLine("---\n");
        }

        static void Main(string[] args)
        {
            // ✅ 4 y 5. Primera llamada CON hobby
            Console.WriteLine("=== PRIMER PERFIL ===");
            CrearPerfil("Programar");

            // ✅ 4 y 5. Segunda llamada SIN hobby
            Console.WriteLine("=== SEGUNDO PERFIL ===");
            CrearPerfil();
        }
    }
}