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
    public class Deposito
    {
        string _codigo;
        int _cantidad, _lugar, _alta, _depoide, _habia;
        public DataTable Mostrar_depositodetalle()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select ld.LUD_DESC,de.DEPO_CANTIDAD,de.DEPO_FECHA,de.DEPO_LUD_IDE,de.DEPO_IDE from deposito as de left join lugares_deposito as ld " +
                                     " on de.DEPO_LUD_IDE = ld.LUD_IDE where de.DEPO_LI_CODIGOVIEJO = '" + this.Codigo + "'");

        }
        public DataTable Mostrar_depositohistorico()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();

            return con.Mostrar_Datos("select ld.LUD_DESC,dh.DEH_HABIA,dh.DEH_HAY,dh.DEH_FECHA from deposito_historico as dh left join lugares_deposito as ld " +
                                     " on dh.DEH_LUD_IDE = ld.LUD_IDE where dh.DEH_LI_CODIGOVIEJO = '" + this.Codigo + "'");

        }
        public DataTable Tabladedatos_depositos()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select LUD_IDE,LUD_DESC from libreria.lugares_deposito order by LUD_DESC");
        }
        public int spAgregarDeposito()
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
                myCommand.CommandText = "spAltaDeposito";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("plugar", this.Lugar);
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pdepoide", this.Depoide);
                myCommand.Parameters.AddWithValue("phabia", this.Habia);
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
        public int spBajaDeposito()
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
                myCommand.CommandText = "spbajadeposito";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("pcantidad", this.Cantidad);
                myCommand.Parameters.AddWithValue("plugar", this.Lugar);
                myCommand.Parameters.AddWithValue("pcodigo", this.Codigo);
                myCommand.Parameters.AddWithValue("pusuide", Globales.gbUsuide);
                myCommand.Parameters.AddWithValue("palta", this.Alta);
                myCommand.Parameters.AddWithValue("pdepoide", this.Depoide);
                myCommand.Parameters.AddWithValue("phabia", this.Habia);
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
        public string Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }
        public int Lugar
        {
            get { return this._lugar; }
            set { this._lugar = value; }
        }
        public int Alta
        {
            get { return this._alta; }
            set { this._alta = value; }
        }
        public int Depoide
        {
            get { return this._depoide; }
            set { this._depoide = value; }
        }
        public int Habia
        {
            get { return this._habia; }
            set { this._habia = value; }
        }
    }
}
