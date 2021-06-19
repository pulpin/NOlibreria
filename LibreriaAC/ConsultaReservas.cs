using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using DevExpress.XtraGrid.Views.Grid;

namespace Presentacion
{
    public partial class ConsultaReservas : Form
    {
        String _codigo;
        Reservas re = new Reservas();
        public ConsultaReservas()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {

          //  this.cargar();
            gridViewPintarFilas.Appearance.FocusedRow.BackColor = Color.Transparent;
          //  gridViewPintarFilas.Appearance.FocusedCell.BackColor = Color.Red;
          //  gridViewPintarFilas.Appearance.SelectedRow.BackColor = Color.Gold;
          //  gridViewPintarFilas.Appearance.HideSelectionRow.BackColor = Color.Gold;
        }
        public void cargar()
        {
            gConsulta.DataSource = re.Mostrar_Reservas();
            if (LogicaNegocios.Globales.accesoareservas == 2)
            {
                btnmodificar.Enabled = true;
            }
            gridViewPintarFilas.Appearance.FocusedRow.BackColor = Color.Transparent;
        }
        public void cargarreseunproducto()
        {
            re.Codigolibro = this.Codigo;
            gConsulta.DataSource = re.Mostrar_Reservasunproducto();
            if (LogicaNegocios.Globales.accesoareservas == 2)
            {
                btnmodificar.Enabled = true;
            }
            gridViewPintarFilas.Appearance.FocusedRow.BackColor = Color.Transparent;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            /*CantiInte ci = new CantiInte();
            ci.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIP_DESC"]));
            ci.Interes = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIP_INTERES"]));
            ci.Codigo = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["TIP_IDE"]));
            ci.colocardatos();
            if (ci.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.cargar();
            }*/

            IngresoClaveRe ic = new IngresoClaveRe();

            /*if (ic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.cargar();
            }*/
            Globales.usureservaide = 0;
            ic.ShowDialog();

            if (Globales.usureservaide != 0)
            {
                this.abrirmodificar();
            }
            else
            {
                MessageBox.Show("Debe ingresar una clave válida!");

            }



        }
        private void abrirmodificar()
        {
            ModificaReserva mr = new ModificaReserva();
            mr.Titulo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_DESC"]));
            mr.Codigo = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_LI_CODIGOVIEJO"]));
            mr.Autor = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_AUTOR"]));
            mr.Cantidad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_CANTIDAD"]));
            mr.Editorial = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_EDITORIAL"]));
            mr.Cliente = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_NOMBRE"]));
            mr.Telefono = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["CLIEN_TELEFONO"]));
            mr.Precio = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_PRECIO"]));
            mr.Reservaide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_IDE"]));
            mr.Cliide = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_CLIE_IDE"]));
            mr.Paraavisarusu = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["paraavisar"]));
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUP_FE"])) != "")
            {
                mr.ParaavisarFe = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUP_FE"]));
            }
            mr.Avisadousu = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["Avisado"]));
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUL_FE"])) != "")
            {
                mr.Avisadofe = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUL_FE"]));
            }
            mr.Entregadousu = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["Entregado"]));
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUE_FE"])) != "")
            {
                mr.Entregadofe = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUE_FE"]));
            }
            
            mr.Alaventausu = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["Alaventa"]));
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUV_FE"])) != "")
            {
                mr.Alaventafe = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUV_FE"]));
            }

            mr.Obs = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_OBS"]));
            mr.Usuariomodifico = Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["usumodificar"]));
            if (Convert.ToString(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUM_FE"])) != "")
            {
                mr.fechamodificado = Convert.ToDateTime(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["RESE_USUM_FE"]));
            }

            mr.colocarDatos();
            
            mr.Alta = 0;
            if (mr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.cargar();
            }
         
        }

        //this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
        private void gridViewPintarFilas_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string estadorese = View.GetRowCellDisplayText(e.RowHandle, View.Columns["RESE_ESTADO"]);

                //  e.Appearance.BackColor = Color.LemonChiffon;

                if (estadorese == "1")
                {
                    e.Appearance.BackColor = Color.PaleGreen;
                    //e.Appearance.BackColor2 = Color.SeaShell;
                }
                else if (estadorese == "2")
                {
                    e.Appearance.BackColor = Color.LightYellow;
                }
                else if (estadorese == "3")
                {
                    e.Appearance.BackColor = Color.Gainsboro;
                }
                else if (estadorese == "4")
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                }


            }
        }

        private void btnparaavisar_Click(object sender, EventArgs e)
        {
            gConsulta.DataSource = re.Mostrar_Reservas(1);
        }

        private void btnavisado_Click(object sender, EventArgs e)
        {
            gConsulta.DataSource = re.Mostrar_Reservas(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gConsulta.DataSource = re.Mostrar_Reservas(3);
        }

        private void btnalaventa_Click(object sender, EventArgs e)
        {
            gConsulta.DataSource = re.Mostrar_Reservas(4);
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            gConsulta.DataSource = re.Mostrar_Reservas();

        }
        public String Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
    }
}
