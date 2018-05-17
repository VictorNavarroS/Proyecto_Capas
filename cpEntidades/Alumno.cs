using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cpEntidades
{
    public class Alumno : Persona // <--- Declaramos la herencia entre alumno y la clase persona.
    {
        // ATRIBUTOS QUE DISTINGUEN A UN ALUMNO DE SU ABSTRACCION (PERSONA)

        private string matricula;
        private bool esRepresentante;
        private short semestreActual;


        // POLIMORFISMO POR SOBRECARGA: METODO CONSTRUCTOR

        public Alumno():base()
        {

        }

        // POLIMORFISMO POR SOBRECARGA: METODO CONSTRUCTOR

        public Alumno(string rut, string nom1, string nom2, string ape1, string ape2, int edad, string matricula, bool esRepresentante, short semestreActual)
            : base(rut,nom1,nom2,ape1,ape2,edad)
        {
            this.matricula = matricula;
            this.esRepresentante = esRepresentante;
            this.semestreActual = semestreActual;
        }

        // ACCESADORES: Encapsulamiento. Expongo los miembros atributos de la clase por medio de metodos que controlan su lectura y escritura.


        public string Matricula
        {
            get { return matricula; }   // ---> Lectura     (get)
            set { matricula = value; }  // ---> Escritura   (set)
        }

        public bool EsRepresentante
        {
            get { return esRepresentante; }
            set { esRepresentante = value; }
        }

        public short SemestreActual
        {
            get { return semestreActual; }
            set { semestreActual = value; }
        }

        // POLIMORFISMO METODO SOBRESCRITO (POLOMORFISMO SOBRE ABSTRACCION)

        public override void saludar()
        {
            Console.WriteLine("Holiwis");
            Console.ReadKey();
        }

        // POLOMORFISMO METODO POR SOBRECARGA

        public void saludar(string quienEs)
        {
            if (quienEs.Equals("Compañero"))
            {
                Console.WriteLine("Hola compañero");
                Console.ReadKey();
            }
            else if(quienEs.Equals("Jefe Carrera"))
            {
                Console.WriteLine("Hola Jefe Carrera");
                Console.ReadKey();
            }
            else if (quienEs.Equals("Profesor"))
            {
                Console.WriteLine("Hola Profesor");
                Console.ReadKey();
            }
            else
            {
                base.saludar();
            }
        }

        // ACCION QUE DISTINGUE A UN ALUMNO

        public void asistirAClases()
        {
            tomarMedioDeTransporte(); // Llamado a un metodo privado oculto a las otras clases.

            Console.WriteLine("Ingrese a clases");
            Console.ReadKey();
        }

        private void tomarMedioDeTransporte()
        {
            Console.WriteLine("Tome el medio de transporte");
            Console.ReadKey();
        }  
    }
}
