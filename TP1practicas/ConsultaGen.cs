using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1practicas
{
    internal class ConsultasGen : Conexion
    {

        private OleDbCommand miComando;
        private OleDbDataAdapter dataAdapter;
        private DataTable dataTable;

        public ConsultasGen(string cadenaConexion) : base(cadenaConexion)
        {

        }
        public bool ValidarUsuario(string usuario, string contraseña)
        {
            try
            {
                Conectar();
                string Consulta = "SELECT COUNT (*) FROM Tabla1 WHERE usuario = ? AND contraseña = ?";

                miComando = new OleDbCommand(Consulta, conectarBase);
                miComando.Parameters.AddWithValue("@usuario", usuario);
                miComando.Parameters.AddWithValue("@contraseña", contraseña);

                int resultado = (int)miComando.ExecuteScalar();
                return resultado > 0;

            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
