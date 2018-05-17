using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cpEntidades
{
    public class Persona
    {

        // Visibilidad y acceso: protected (solo la misma clase o quienes heredan de la misma pueden acceder)
       
        protected string rut;
        protected string nombre_1;
        protected string nombre_2;
        protected string apellido_p;
        protected string apellido_m;
        protected int edad;

        // metodos constructores: permiten instanciar la clase

        public Persona()
        {

        }

        public Persona(string rut, string nom1, string nom2, string ape1, string ape2, int edad)
        {
            this.rut = rut;
            this.nombre_1 = nom1;
            this.nombre_2 = nom2;
            this.apellido_p = ape1;
            this.apellido_m = ape2;
            this.edad = edad;
        }

        public string _rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string _nombre1
        {
            get { return nombre_1; }
            set { nombre_1 = value; }
        }

        public string _nombre_2
        {
            get { return nombre_2; }
            set { nombre_2 = value; }
        }

        public string _apellido_p
        {
            get { return apellido_p; }
            set { apellido_p = value; }
        }

        public string _apellido_m
        {
            get { return apellido_m; }
            set { apellido_m = value; }
        }

        public int _edad
        {
            get { return edad; }
            set { edad = value; }
        }

        // POLIMORFISMO POR ABSTRACCION METODO VIRTUAL 

        public virtual void saludar()
        {
            Console.WriteLine("Hola");
            Console.ReadKey();
        }
    }
}
