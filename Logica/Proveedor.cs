using AccesoaDatos;
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
        public DataTable Tabladedatos_proveedores()
        {
            Conexion con = new Conexion("libreria", Globales.ip);
            con.AbrirConexio();
            return con.Mostrar_Datos("select PROV_IDE,PROV_DESC from libreria.proveedor order by PROV_DESC");
        }
    }
}
