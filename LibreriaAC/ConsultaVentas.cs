﻿using System;
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
    public partial class ConsultaVentas : Form
    {
        Venta ve = new Venta();
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void ConsultaInteres_Load(object sender, EventArgs e)
        {
            this.cargar();
        }
        private void cargar()
        {
            gConsulta.DataSource = ve.Mostrar_ventas100();
           // fechadesde.EditValue = DateTime.Today;
           // fechahasta.EditValue = DateTime.Today;
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
            this.seleccionado();
        }

        private void seleccionado()
        {

                int venidep1 = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_IDE"]));
                ConsultaVentasProduc cvp = new ConsultaVentasProduc();
                cvp.Vendidep = venidep1;
                cvp.ShowDialog();            
        }

        private void gConsulta_DoubleClick(object sender, EventArgs e)
        {
            this.seleccionado();
        }

        private void btnaltacliente_Click(object sender, EventArgs e)
        {
            AltaCliente ac = new AltaCliente();
            ac.Alta = 1;
            
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();
            }
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e)
        {
            ConsultaPermisos cp = new ConsultaPermisos();
            cp.Codigo = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["USU_IDE"]));
            if (cp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //gConsulta.DataSource = cli.Mostrar_clientes();

            }
        }
        //this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
        private void gridViewPintarFilas_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string estadorese = View.GetRowCellDisplayText(e.RowHandle, View.Columns["VEN_ANULADO"]);

                //  e.Appearance.BackColor = Color.LemonChiffon;

                if (estadorese == "1")
                {
                    e.Appearance.BackColor = Color.DarkOrange;
                    //e.Appearance.BackColor2 = Color.SeaShell;
                }
                else if (estadorese == "2")
                {
                    e.Appearance.BackColor = Color.IndianRed;
                }
              /*  else if (estadorese == "2")
                {
                    e.Appearance.BackColor = Color.Gainsboro;
                }*/
                
            }
        }

        private void btnnotadecredito_Click(object sender, EventArgs e)
        {
          int anulad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_ANULADO"]));
            if (anulad == 0)
            {
                NotadeCredito ndc = new NotadeCredito();
                ndc.Ultimavta = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_IDE"]));
                ndc.NotaParcial = 1;
                
                if (ndc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //gConsulta.DataSource = cli.Mostrar_clientes();
                    MessageBox.Show("Se ha creado la nota de crédito");
                    this.cargar();
                }
            }
            else
            {
                MessageBox.Show("Ya existe una nota de crédito para esta venta");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int anulad = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_ANULADO"]));
            if (anulad == 0)
            {
                NotadeCredito ndc = new NotadeCredito();
                ndc.Ultimavta = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_IDE"]));
                ndc.NotaParcial = 0;
                
                if (ndc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Se ha creado la nota de crédito");
                    //gConsulta.DataSource = cli.Mostrar_clientes();
                    this.cargar();
                }
            }
            else
            {
                MessageBox.Show("Ya existe una nota de crédito para esta venta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotadeCredito ndc = new NotadeCredito();
            ndc.Ultimavta = Convert.ToInt32(this.gridViewPintarFilas.GetRowCellValue(gridViewPintarFilas.FocusedRowHandle, this.gridViewPintarFilas.Columns["VEN_IDE"]));
            ndc.NotaParcial = 3;
            ndc.ShowDialog();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            DateTime fdesde = Convert.ToDateTime(fechadesde.EditValue);
            string fdesdee = fdesde.ToString("yyyy-MM-dd");

            DateTime fhasta = Convert.ToDateTime(fechahasta.EditValue);
            string fhastae = fhasta.ToString("yyyy-MM-dd");
            int nrofac = 0;
            if (txtnrofactu.Text != string.Empty)
            {
                nrofac = Convert.ToInt32(txtnrofactu.Text);
            }

            gConsulta.DataSource = ve.Mostrar_ventasporparametro(fdesdee, fhastae, nrofac);

        }
    }
}
