using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cpPersistencia;
using cpEntidades;

namespace cpNegocio
{
    public class negAlumno
    {
        public void registrarAlumno(Alumno alumno, out string msjValida)
        {
            msjValida = "";
            
            if (String.IsNullOrEmpty(alumno._rut))
            {
                msjValida = "El campo rut viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(alumno._nombre1))
            {
                msjValida += "El campo primer nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(alumno._nombre_2))
            {
                msjValida += "El campo segundo nombre viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(alumno._apellido_p))
            {
                msjValida += "El campo apellido paterno viene vacio" + "\n";
            }

            if (String.IsNullOrEmpty(alumno._apellido_m))
            {
                msjValida += "El campo apellido materno viene vacio" + "\n";
            }

            if (msjValida.Equals(""))
            {
                perAlumno cpAlumno = new perAlumno();
                bool exito = cpAlumno.insertaAlumnoEnBD(alumno);

                if (exito == false)
                {
                    msjValida += "Error en el proceso de registro del alumno rut" + alumno._rut;
                }
            }
        }

        public List<Alumno> seleccionAlumnos(string tipoConsulta, out string msjValida)
        {
            msjValida = "";

            try
            {
                if (tipoConsulta.Equals("TODOS"))
                {
                    perAlumno cpAlumno = new perAlumno();
                    return cpAlumno.listarTodosLosAlumnos();
                }
                else if (!tipoConsulta.Equals("DELEGADOS"))
                {
                    perAlumno cpAlumno = new perAlumno();
                    return cpAlumno.listarTodosLosAlumnosDelegados();
                }
                else
                {
                    msjValida = "No has seleccionado ningún tipo de consulta";
                    return null;
                }
            }
            catch (Exception ex)
            {
                msjValida = ex.Message;
                return null;
            }
        }
    }
}
