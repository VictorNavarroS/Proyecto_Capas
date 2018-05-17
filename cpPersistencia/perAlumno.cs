using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cpEntidades;
using System.Data;

namespace cpPersistencia
{
    public class perAlumno
    {
        public bool insertaAlumnoEnBD(Alumno alumno)
        {
            try
            {
                ConexionBD conexion = new ConexionBD();

                string sqlQuery = "insert into alumnos (rut,nombre1,nombre2,ape1,ape2,edad,matricula,semestre,esRepresentante) values ('" + alumno._rut + "','" + alumno._nombre1 + "','" + alumno._nombre_2 + "',"+
                "'"+alumno._apellido_p + "','"+alumno._apellido_m + "',"+ alumno._edad+",'"+alumno.Matricula + "',"+alumno.SemestreActual+",'"+alumno.EsRepresentante+"');";

                return conexion.manipulaData(sqlQuery);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public List<Alumno> listarTodosLosAlumnos()
        {
            try
            {
                ConexionBD conexion = new ConexionBD();
                DataTable miTabla = conexion.selecData("select * from alumnos");
                List<Alumno> listaDeTodosLosAlumnos = new List<Alumno>();

                for (int i = 0; i < miTabla.Rows.Count; i++)
                {
                    Alumno alumno = new Alumno();

                    alumno._rut = miTabla.Rows[i]["rut"].ToString();
                    alumno._nombre1 = miTabla.Rows[i]["nombre1"].ToString();
                    alumno._nombre_2 = miTabla.Rows[i]["nombre2"].ToString(); 
                    alumno._apellido_p = miTabla.Rows[i]["ape1"].ToString();
                    alumno._apellido_m = miTabla.Rows[i]["ape2"].ToString();
                    alumno._edad = int.Parse(miTabla.Rows[i]["edad"].ToString());
                    alumno.Matricula = miTabla.Rows[i]["matricula"].ToString();
                    alumno.SemestreActual = short.Parse(miTabla.Rows[i]["semestre"].ToString());
                    alumno.EsRepresentante = bool.Parse(miTabla.Rows[i]["esRepresentante"].ToString());

                    listaDeTodosLosAlumnos.Add(alumno);
                }

                return listaDeTodosLosAlumnos;
            }
            catch (Exception)
            {
                return null;
            }

        }
    
        public List<Alumno> listarTodosLosAlumnosDelegados()
        {
 	         try
            {
                ConexionBD conexion = new ConexionBD();
                DataTable miTabla = conexion.selecData("select * from alumnos where esRepresentante = 1");
                List<Alumno> listaDeTodosLosAlumnos = new List<Alumno>();

                for (int i = 0; i < miTabla.Rows.Count; i++)
                {
                    Alumno alumno = new Alumno();

                    alumno._rut = miTabla.Rows[i]["rut"].ToString();
                    alumno._nombre1 = miTabla.Rows[i]["nombre1"].ToString();
                    alumno._nombre_2 = miTabla.Rows[i]["nombre2"].ToString(); 
                    alumno._apellido_p = miTabla.Rows[i]["ape1"].ToString();
                    alumno._apellido_m = miTabla.Rows[i]["ape2"].ToString();
                    alumno._edad = int.Parse(miTabla.Rows[i]["edad"].ToString());
                    alumno.Matricula = miTabla.Rows[i]["matricula"].ToString();
                    alumno.SemestreActual = short.Parse(miTabla.Rows[i]["semestre"].ToString());
                    alumno.EsRepresentante = bool.Parse(miTabla.Rows[i]["esRepresentante"].ToString());

                    listaDeTodosLosAlumnos.Add(alumno);
                }

                return listaDeTodosLosAlumnos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
