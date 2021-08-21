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
    public class Proveedor
    {
        string _titulo;
        int _alta, _ide;
        public DataTable Tabladedatos_proveedores()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select PROV_IDE,PROV_DESC from libreria.proveedor order by PROV_DESC");
        }

        public DataTable Tabladedatos_proveedoresbuscar()
        {
            string valor = string.Empty, contiene;
            if (this.Titulo != string.Empty)
            {
                contiene = "%";
                valor = "PROV_DESC like " + "'" + contiene + "" + Titulo + "%" + "'";
            }

            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select * from libreria.proveedor where " + valor + " order by PROV_DESC");
        }

        public int spAgregarProveedor()
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
                myCommand.CommandText = "spAltaProveedor";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pproveedor", this.Titulo);
                myCommand.Parameters.AddWithValue("palta", 1);
                myCommand.Parameters.AddWithValue("pide", 0);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);

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
        public int spModificarProveedor()
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
                myCommand.CommandText = "spAltaProveedor";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pproveedor", this.Titulo);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pide", this.Ide);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);

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

        public int spBajaProveedor()
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
                myCommand.CommandText = "spbajaproveedor";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pidep", this.Ide);

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

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }
        public int Ide
        {
            get { return this._ide; }
            set { this._ide = value; }
        }

    }
}
