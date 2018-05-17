using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cpEntidades
{
    public class JefeCarrera : Persona
    {
        private int codIngresoOficina;

        public JefeCarrera()
        {

        }

        public JefeCarrera(string rut, string nom1, string nom2, string ape1, string ape2, int edad, int codIngreso)
            : base(rut,nom1,nom2,ape1,ape2,edad)
        {
            this.codIngresoOficina = codIngreso;
        }

        public string rut_
        {
            get { return rut; }
            set { rut = value; }
        }

        public string nombre_1
        {
            get { return nombre_1; }
            set { nombre_1 = value; }
        }
        public int CodIngresoOficina
        {
            get { return codIngresoOficina; }
            set { codIngresoOficina = value; }
        }

        public override void saludar()
        {
            Console.WriteLine("Hola");
            Console.ReadKey();
        }

        public void saludar(string quienEs)
        {
            if (quienEs.Equals("Estudiante"))
            {
                Console.WriteLine("Hola Estudiante");
                Console.ReadKey();
            }
            else if (quienEs.Equals("Docente"))
            {
                Console.WriteLine("Hola Docente");
                Console.ReadKey();
            }
            else if (quienEs.Equals("Par"))
            {
                Console.WriteLine("Hola Colega");
                Console.ReadKey();
            }
            else
            {
                base.saludar();
            }
        }

        public void inscribirAlumnoEnModulo(Alumno alumno, string modulo)
        {
            Console.WriteLine("El alumno {0} fue inscrito en el modulo de {1}", alumno._nombre1, modulo);
            Console.ReadKey();
        }

        public void ingresarOficina(int codigo)
        {
            if (codigo == codIngresoOficina)
            {
                Console.WriteLine("Acceso Correcto");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Intente de nuevo por favor");
                Console.ReadKey();
            }
        }
    }
}
