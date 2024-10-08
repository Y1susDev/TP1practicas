using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1practicas
{
    internal class Conexion
    {
        private string cadena;
        protected OleDbConnection conectarBase;
        public Conexion(string cadenaConexion)
        {
            cadena = cadenaConexion;
        }

        protected void Conectar()
        {
            conectarBase = new OleDbConnection(cadena);
            conectarBase.Open();
        }

        protected void Desconectar()
        {
            if (conectarBase.State == System.Data.ConnectionState.Open)
                conectarBase.Close();
        }
    }
}
