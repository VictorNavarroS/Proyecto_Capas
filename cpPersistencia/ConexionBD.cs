using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace cpPersistencia
{
    public class ConexionBD
    {
        private string cadena = @"Data Source=TINTO-PC\SQLEXPRESS;Initial Catalog =aiep;User Id=sa;Password=tinto666;";

        private SqlConnection conexion;
        private SqlCommand sqlComando;
        private SqlDataAdapter sqlAdaptador;

        public ConexionBD()
        {
            conexion = new SqlConnection(cadena);
        }

        public void probarConexion(out string estado)
        {
            try
            {
                conexion.Open();
                conexion.Close();
                estado = "Conectado";
            }
            catch (Exception ex)
            {
                estado = "Fallo en la conexión : " + ex.Message;
            }
        }

        public bool manipulaData(string manipulaSql)
        {
            try
            {
                DataTable miTablaDatos = new DataTable();

                sqlComando = new SqlCommand(manipulaSql, conexion);

                conexion.Open();

                int aux = sqlComando.ExecuteNonQuery();

                conexion.Close();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public DataTable selecData(string consultaSql)
        {
            try
            {
                DataTable miTablaDatos = new DataTable();

                sqlAdaptador = new SqlDataAdapter(consultaSql, conexion);

                conexion.Open();

                sqlAdaptador.Fill(miTablaDatos);

                conexion.Close();

                return miTablaDatos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool ejecutaProcedimientoAlmacenadoManipulacion(SqlParameter[] parametros, string nombreSP)
        {
            try
            {
                DataTable miTablaDatos = new DataTable();

                sqlAdaptador = new SqlDataAdapter(nombreSP, conexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter sqlP in parametros)
	            {
                    sqlAdaptador.SelectCommand.Parameters.Add(sqlP);
	            }

                conexion.Open();

                int aux = sqlComando.ExecuteNonQuery();

                conexion.Close();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ejecutaProcedimientoAlmacenadoSeleccion(SqlParameter[] parametros, string nombreSP)
        {
            try
            {
                DataTable miTablaDatos = new DataTable();

                sqlAdaptador = new SqlDataAdapter(nombreSP, conexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter sqlP in parametros)
                {
                    sqlAdaptador.SelectCommand.Parameters.Add(sqlP);
                }

                conexion.Open();

                 sqlAdaptador.Fill(miTablaDatos);

                conexion.Close();

                return miTablaDatos;
            }
            catch (Exception)
            {
                return null;
            }
    
        }
    }
}
