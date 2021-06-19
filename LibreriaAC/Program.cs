using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using LogicaNegocios;
using System.Configuration;
using Presentacion.Properties;
using MySql.Data.MySqlClient;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
     //   static int salir;
        [STAThread]
        

        static void Main(string[] args)
        {   
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-ES");
           // nfi.NumberDecimalSeparator = ".";
           // nfi.CurrencyDecimalSeparator = ".";

                String usuario = string.Empty, contra = string.Empty, ip = string.Empty;
                

                if (args.Length >= 1)
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                     
                        usuario = args[1];
                        contra = args[2];
                        Globales.ip = args[3];
                        
                      //  salir = 0;
                    }
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // comprueba si no tiene nada lo setea al servidor local
                if (Globales.ip == null)
                {
                //  Globales.ip = "200.51.42.91";
                 Globales.ip = "localhost";
                //Globales.ip = "10.1.10.202";

                /*Configuration conf = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                ConnectionStringsSection css = conf.ConnectionStrings;
                string cadena = "server=" + Convert.ToString(Globales.ip) + ";User Id=root;password=r69775;Persist Security Info=True;database=derivacion";
                css.ConnectionStrings["Presentacion.Properties.Settings.derivacionConnectionString"].ConnectionString = cadena;
                conf.Save();*/
            }

                //verifica la versión del programa, si hay una nueva cierra y llama al exe para actualizar
                /*
                VersionProg ve = new VersionProg();
                MySqlDataReader myReader2 = ve.MostrarVersion();
                if (myReader2.HasRows)
                {
                    while (myReader2.Read())
                    {
                        //pregunta si la versión de este software es la misma de la base de datos
                        if (20160407 != myReader2.GetInt32(myReader2.GetOrdinal("prog_version")))
                        {
                            MessageBox.Show("Hay una nueva versión del sistema, se procederá a actualizar! ");
                            salir = 1;
                            try
                            {
                                System.Diagnostics.Process.Start("instalador_version.exe", "16 " + Globales.ip + "");
                            }
                            catch 
                            {
                                MessageBox.Show("Error en la actualización (no se encuentra el instalador), contáctese con el sector de informática");
                            }
                        }
                    }
                }
                
                */
                // preguntar si necesito actualizar el programa...


                        Application.Run(new Login());
                   
                

        }
    }
}
