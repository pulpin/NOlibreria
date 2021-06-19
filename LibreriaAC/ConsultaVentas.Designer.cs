namespace Presentacion
{
    partial class ConsultaVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewPintarFilas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VEN_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TIPOFACTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NROTICKET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_TOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VEN_ANULADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnotadecredito = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 37);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(647, 351);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gConsulta.DoubleClick += new System.EventHandler(this.gConsulta_DoubleClick);
            this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VEN_IDE,
            this.VEN_TIPOFACTU,
            this.VEN_NROTICKET,
            this.VEN_FECHA,
            this.VEN_NOMBRE,
            this.VEN_TOTAL,
            this.VEN_ANULADO});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // VEN_IDE
            // 
            this.VEN_IDE.Caption = "Factura";
            this.VEN_IDE.FieldName = "VEN_IDE";
            this.VEN_IDE.MaxWidth = 90;
            this.VEN_IDE.MinWidth = 90;
            this.VEN_IDE.Name = "VEN_IDE";
            this.VEN_IDE.Visible = true;
            this.VEN_IDE.VisibleIndex = 0;
            this.VEN_IDE.Width = 90;
            // 
            // VEN_TIPOFACTU
            // 
            this.VEN_TIPOFACTU.Caption = "Factura";
            this.VEN_TIPOFACTU.FieldName = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.Name = "VEN_TIPOFACTU";
            this.VEN_TIPOFACTU.Visible = true;
            this.VEN_TIPOFACTU.VisibleIndex = 1;
            // 
            // VEN_NROTICKET
            // 
            this.VEN_NROTICKET.Caption = "Tickets";
            this.VEN_NROTICKET.FieldName = "VEN_NROTICKET";
            this.VEN_NROTICKET.Name = "VEN_NROTICKET";
            this.VEN_NROTICKET.Visible = true;
            this.VEN_NROTICKET.VisibleIndex = 2;
            // 
            // VEN_FECHA
            // 
            this.VEN_FECHA.Caption = "Fecha";
            this.VEN_FECHA.FieldName = "VEN_FECHA";
            this.VEN_FECHA.Name = "VEN_FECHA";
            this.VEN_FECHA.Visible = true;
            this.VEN_FECHA.VisibleIndex = 3;
            // 
            // VEN_NOMBRE
            // 
            this.VEN_NOMBRE.Caption = "Cliente";
            this.VEN_NOMBRE.FieldName = "VEN_NOMBRE";
            this.VEN_NOMBRE.Name = "VEN_NOMBRE";
            this.VEN_NOMBRE.Visible = true;
            this.VEN_NOMBRE.VisibleIndex = 4;
            // 
            // VEN_TOTAL
            // 
            this.VEN_TOTAL.Caption = "Importe";
            this.VEN_TOTAL.FieldName = "VEN_TOTAL";
            this.VEN_TOTAL.Name = "VEN_TOTAL";
            this.VEN_TOTAL.Visible = true;
            this.VEN_TOTAL.VisibleIndex = 5;
            // 
            // VEN_ANULADO
            // 
            this.VEN_ANULADO.Caption = "VEN_ANULADO";
            this.VEN_ANULADO.FieldName = "VEN_ANULADO";
            this.VEN_ANULADO.Name = "VEN_ANULADO";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar32;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(464, 395);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 59);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnotadecredito
            // 
            this.btnnotadecredito.BackColor = System.Drawing.SystemColors.Control;
            this.btnnotadecredito.Image = global::Presentacion.Properties.Resources.agregarE322;
            this.btnnotadecredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnotadecredito.Location = new System.Drawing.Point(101, 395);
            this.btnnotadecredito.Name = "btnnotadecredito";
            this.btnnotadecredito.Size = new System.Drawing.Size(104, 59);
            this.btnnotadecredito.TabIndex = 15;
            this.btnnotadecredito.Text = "Crear parcial";
            this.btnnotadecredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnotadecredito.UseVisualStyleBackColor = false;
            this.btnnotadecredito.Click += new System.EventHandler(this.btnnotadecredito_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::Presentacion.Properties.Resources.ajuste32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(222, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 59);
            this.button3.TabIndex = 16;
            this.button3.Text = "Crear total";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nota de crédito PARCIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nota de crédito TOTAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::Presentacion.Properties.Resources.buscar32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(343, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 59);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ver nota de crédito";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 460);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnnotadecredito);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas...";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_IDE;
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TIPOFACTU;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NROTICKET;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_TOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn VEN_ANULADO;
        private System.Windows.Forms.Button btnnotadecredito;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}