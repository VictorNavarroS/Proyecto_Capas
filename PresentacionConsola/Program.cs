using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cpEntidades;
using cpNegocio;

namespace PresentacionConsola
{
    class Program
    {
        private static string op = "";

        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("===============================================");
                Console.WriteLine("    Bienvenido al Sistema de Alumnos AIEP      ");
                Console.WriteLine("===============================================");
                Console.WriteLine(@"                   \|||/                      ");
                Console.WriteLine(@"                   (o o)                      ");
                Console.WriteLine(@"          ------ooO-(_)-Ooo------             ");
                Console.WriteLine("===============================================");
                Console.WriteLine("             ¿Que deseas hacer?                 ");
                Console.WriteLine("===============================================");
                Console.WriteLine(" [1] Registrar alumno.                         ");
                Console.WriteLine(" [2] Consultar todos los alumnos.              ");
                Console.WriteLine(" [3] Consultar todos los delegados.            ");
                Console.WriteLine(" [4] Salir.                                    ");
                Console.WriteLine("===============================================");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Clear();

                        Alumno alumno = new Alumno();

                        Console.WriteLine("===============================================");
                        Console.WriteLine("    Ingrese los datos según se solicita        ");
                        Console.WriteLine("===============================================" + "\n");

                        Console.Write("Ingrese el rut                       : ");
                        alumno._rut = Console.ReadLine();

                        Console.Write("Ingrese el primer nombre             : ");
                        alumno._nombre1 = Console.ReadLine();

                        Console.Write("Ingrese el segundo nombre            : ");
                        alumno._nombre_2 = Console.ReadLine();

                        Console.Write("Ingrese el primer apellido           : ");
                        alumno._apellido_p = Console.ReadLine();

                        Console.Write("Ingrese el segundo apellido          : ");
                        alumno._apellido_m = Console.ReadLine();

                        Console.Write("Ingrese la edad                      : ");
                        alumno._edad = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese la matricula                 : ");
                        alumno.Matricula = Console.ReadLine();

                        Console.Write("Ingrese si es representante          : ");
                        alumno.EsRepresentante =bool.Parse( Console.ReadLine());

                        Console.Write("Ingrese el semestre actual           : ");
                        alumno.SemestreActual =short.Parse( Console.ReadLine());

                        negAlumno negAlumno = new negAlumno();
                        string msj;
                        negAlumno.registrarAlumno(alumno,out msj);
                        if (String.IsNullOrEmpty(msj))
                        {
                            Console.WriteLine("Hey! datos ingresados correctamente");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine(msj);
                        }
                        Console.Clear();

                        break;
                    case "2":
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("===============================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("               ¡Opcion Invalida!               ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("===============================================");
                        Console.WriteLine("         Presiona una tecla para continuar     ");
                        Console.WriteLine("===============================================");
                        Console.ReadKey();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (op != "4");


        }
    }
}
