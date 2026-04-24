using System;
using System.Collections.Generic;
using System.Globalization;
using system.IO;

namespace PrestamosEquipos
{
    public class prestamo
    {
        private String Codigo;
        private string NombreEstudiante;
        private string equipo;
        private string carné;
        private string TiempoPrestamo;
        private string Estado;

        public prestamo(string codigo, String NombrEstudiante, string Equipo, string Carné, string TiempoPrestamo, string Estado)
        {
            this.Codigo = codigo;
            this.NombreEstudiante = NombrEstudiante;
            this.equipo = Equipo;
            this.carné = Carné;
            this.TiempoPrestamo = TiempoPrestamo;
            this.Estado = Estado;

        }

        public string ObtenerDatos()
        {
            return $"código: {Codigo}\n Estudiante : {NombreEstudiante}\n carné: {carné}\n Equipo: {equipo}\n" + $"Tiempo: {TiempoPrestamo} dias\n Estado: {Estado}";

        }
    }
    class program
    {
        static Dictionary<string, prestamo> prestamos = new Dictionary<string, ´prestamo>();
        static void Main(string[] args)
        {
            string rutaArchivo = "prestamos.txt";
            bool salir = false;
            do
            {
                Console.WriteLine("\n menú principal");
                Console.WriteLine("opcion 1: registrar prestamo");
                Console.WriteLine("opcion 2: mostrar informacion de prstamos");
                Console.WriteLine("opcion 3: guardar prestamos en archivo");
                Console.WriteLine("opcion 4: salir");
                Console.WriteLine("ingrese una opcion");
                string opcion = Console.ReadLine();


                switch (opcion)
                {
                    case 1:
                        registrarprestamo();
                        break;
                    case 2:
                        MostrarPrestamo();
                        break;
                    case 3:
                        GuardarPrestamos(rutaArchivo);
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("opción inválida");
                        break;
                } while (!salir) ;

            }

            static void RegistrarPrestamo()
            {
                Console.WriteLine("código del prestamo: ");
                string codigo = Console.ReadLine();
                Console.WriteLine("Nombre del Estudiante: ");
                string NombreEstudiante = Console.ReadLine();
                Console.WriteLine("No. Carné:");
                string carné = Console.ReadLine();
                Console.WriteLine("Equipo prestado: ");
                string equipo = Console.ReadLine();
                Console.WriteLine("Tiempo de prestamo (en días): ");
                string
            }
        }


    }