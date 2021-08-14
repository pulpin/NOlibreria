using AccesoaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class DineroCaja
    {
        string _obs, _precio;
        int _ide;
        public DataTable Mostrar_dinerocaja()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select PC_FECHA,PC_DINERO,PC_OBS,PC_IDE,PC_PUNTODEVTA from plata_caja where PC_PUNTODEVTA = "+ Globales.puntodeventa + " order by PC_FECHA desc");

        }

        public DataTable Mostrar_dinerocajahoy()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select PC_FECHA,PC_DINERO,PC_OBS,PC_IDE,PC_PUNTODEVTA from plata_caja where PC_PUNTODEVTA = " + Globales.puntodeventa + " and PC_FECHA = CURDATE() order by PC_FECHA desc");

        }

        public int spVerDineroCaja()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("libreria", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spVerDineroCaja";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ptodeventa", Globales.puntodeventa);
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }
        public int spAltaDineroCaja()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;

            Conexion con = new Conexion("libreria", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spAltaDineroCaja";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("ptodeventa", Globales.puntodeventa);
                myCommand.Parameters.AddWithValue("precio", this.Precio);
                myCommand.Parameters.AddWithValue("obs", this.Obs);
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }

        public int spBajaDineroCaja()
        {
            int Valor_Retornado = 0;
            string cadenaconexion;


            Conexion con = new Conexion("libreria", Globales.ip);
            cadenaconexion = con.inicializa();
            MySqlConnection mysql_conexion = con.AbrirConexion(cadenaconexion);
            mysql_conexion.Open();
            MySqlTransaction sqlTran = mysql_conexion.BeginTransaction();
            MySqlCommand myCommand = mysql_conexion.CreateCommand();
            myCommand.Transaction = sqlTran;

            try
            {
                myCommand.Connection = mysql_conexion;
                myCommand.CommandText = "spbajadinerocaja";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcide", this.Ide);
                MySqlParameter ValorRetorno = new MySqlParameter("@Resultado", MySqlDbType.Int32);
                ValorRetorno.Direction = ParameterDirection.Output;// Output;
                myCommand.Parameters.Add(ValorRetorno);
                myCommand.ExecuteNonQuery();
                Valor_Retornado = Convert.ToInt32(ValorRetorno.Value);
                sqlTran.Commit();
                mysql_conexion.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception if the transaction fails to commit.
                Console.WriteLine(ex.Message);

                try
                {
                    // Attempt to roll back the transaction.
                    sqlTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    Console.WriteLine(exRollback.Message);
                }
            }

            return Valor_Retornado;
        }
        public string Obs
        {
            get { return this._obs; }
            set { this._obs = value; }
        }

        public string Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }

    }
}
