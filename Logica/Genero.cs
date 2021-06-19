using AccesoaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogicaNegocios
{
    public class Genero
    {
        public DataTable Tabladedatos_genero()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select GEN_IDE,GEN_DESC from libreria.genero order by GEN_DESC");
        }
    }
}
