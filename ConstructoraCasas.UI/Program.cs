using System;
using ConstructoraCasas.BLL;
using ConstructoraCasas.BLL.Builders;
using ConstructoraCasas.Domain;

namespace ConstructoraCasas.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE CONSTRUCCIÓN DE CASAS (Patrón Builder) ===\n");

            // --- ESCENARIO 1: Casa de Madera (Con todos los opcionales) ---
            Console.WriteLine("Iniciando construcción: Casa de Madera (Completa)");

            // 1. Instanciamos el builder específico
            ICasaBuilder builderMadera = new CasaMaderaBuilder();

            // 2. Instanciamos el director y le pasamos el builder
            DirectorConstructora directorMadera = new DirectorConstructora(builderMadera);

            // 3. El director ejecuta los pasos (conSotano: true, conSegundoPiso: true, pintar: true)
            directorMadera.ConstruirCasa(true, true, true);

            // 4. Obtenemos el producto final y lo mostramos
            Casa casaMaderaTerminada = builderMadera.ObtenerCasa();
            Console.WriteLine(casaMaderaTerminada.MostrarDetalles());
            Console.WriteLine("\n--------------------------------------------------\n");


            // --- ESCENARIO 2: Casa de Ladrillo (Sin sótano, sin 2do piso, sin pintar) ---
            Console.WriteLine("Iniciando construcción: Casa de Ladrillo (Básica/Económica)");

            // 1. Instanciamos el builder específico
            ICasaBuilder builderLadrillo = new CasaLadrilloBuilder();

            // 2. Instanciamos el director y le pasamos el builder
            DirectorConstructora directorLadrillo = new DirectorConstructora(builderLadrillo);

            // 3. El director ejecuta los pasos (conSotano: false, conSegundoPiso: false, pintar: false)
            directorLadrillo.ConstruirCasa(false, false, false);

            // 4. Obtenemos el producto final y lo mostramos
            Casa casaLadrilloTerminada = builderLadrillo.ObtenerCasa();
            Console.WriteLine(casaLadrilloTerminada.MostrarDetalles());

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
