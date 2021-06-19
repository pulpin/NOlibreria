namespace Presentacion
{
    partial class ConsultaReservas
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
            this.CLIEN_NOMBRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CLIEN_TELEFONO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_LI_CODIGOVIEJO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_AUTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_EDITORIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_PRECIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_CANTIDAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_FECHA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cargado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.paraavisar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Avisado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Entregado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_ESTADO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_CLIE_IDE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Alaventa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUV_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_OBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUP_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usumodificar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RESE_USUM_FE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnparaavisar = new System.Windows.Forms.Button();
            this.btnavisado = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnalaventa = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // gConsulta
            // 
            this.gConsulta.Location = new System.Drawing.Point(12, 12);
            this.gConsulta.MainView = this.gridViewPintarFilas;
            this.gConsulta.Name = "gConsulta";
            this.gConsulta.Size = new System.Drawing.Size(960, 364);
            this.gConsulta.TabIndex = 1;
            this.gConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPintarFilas});
            this.gridViewPintarFilas.RowStyle += gridViewPintarFilas_RowStyle;
            // 
            // gridViewPintarFilas
            // 
            this.gridViewPintarFilas.Appearance.SelectedRow.BackColor = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent;
            this.gridViewPintarFilas.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewPintarFilas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewPintarFilas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPintarFilas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CLIEN_NOMBRE,
            this.CLIEN_TELEFONO,
            this.RESE_LI_CODIGOVIEJO,
            this.RESE_DESC,
            this.RESE_AUTOR,
            this.RESE_EDITORIAL,
            this.RESE_PRECIO,
            this.RESE_CANTIDAD,
            this.RESE_FECHA,
            this.RESE_IDE,
            this.Cargado,
            this.paraavisar,
            this.Avisado,
            this.Entregado,
            this.RESE_ESTADO,
            this.RESE_CLIE_IDE,
            this.Alaventa,
            this.RESE_USUV_FE,
            this.RESE_OBS,
            this.RESE_USUP_FE,
            this.usumodificar,
            this.RESE_USUM_FE});
            this.gridViewPintarFilas.GridControl = this.gConsulta;
            this.gridViewPintarFilas.Name = "gridViewPintarFilas";
            this.gridViewPintarFilas.OptionsBehavior.Editable = false;
            this.gridViewPintarFilas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewPintarFilas.OptionsView.ShowFooter = true;
            // 
            // CLIEN_NOMBRE
            // 
            this.CLIEN_NOMBRE.Caption = "Cliente";
            this.CLIEN_NOMBRE.FieldName = "CLIEN_NOMBRE";
            this.CLIEN_NOMBRE.MaxWidth = 150;
            this.CLIEN_NOMBRE.MinWidth = 150;
            this.CLIEN_NOMBRE.Name = "CLIEN_NOMBRE";
            this.CLIEN_NOMBRE.Visible = true;
            this.CLIEN_NOMBRE.VisibleIndex = 0;
            this.CLIEN_NOMBRE.Width = 150;
            // 
            // CLIEN_TELEFONO
            // 
            this.CLIEN_TELEFONO.Caption = "Teléfono";
            this.CLIEN_TELEFONO.FieldName = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.Name = "CLIEN_TELEFONO";
            this.CLIEN_TELEFONO.Visible = true;
            this.CLIEN_TELEFONO.VisibleIndex = 1;
            this.CLIEN_TELEFONO.Width = 67;
            // 
            // RESE_LI_CODIGOVIEJO
            // 
            this.RESE_LI_CODIGOVIEJO.Caption = "Código";
            this.RESE_LI_CODIGOVIEJO.FieldName = "RESE_LI_CODIGOVIEJO";
            this.RESE_LI_CODIGOVIEJO.MaxWidth = 60;
            this.RESE_LI_CODIGOVIEJO.MinWidth = 60;
            this.RESE_LI_CODIGOVIEJO.Name = "RESE_LI_CODIGOVIEJO";
            this.RESE_LI_CODIGOVIEJO.Visible = true;
            this.RESE_LI_CODIGOVIEJO.VisibleIndex = 2;
            this.RESE_LI_CODIGOVIEJO.Width = 60;
            // 
            // RESE_DESC
            // 
            this.RESE_DESC.Caption = "Descripción";
            this.RESE_DESC.FieldName = "RESE_DESC";
            this.RESE_DESC.MaxWidth = 200;
            this.RESE_DESC.MinWidth = 200;
            this.RESE_DESC.Name = "RESE_DESC";
            this.RESE_DESC.Visible = true;
            this.RESE_DESC.VisibleIndex = 3;
            this.RESE_DESC.Width = 200;
            // 
            // RESE_AUTOR
            // 
            this.RESE_AUTOR.Caption = "Autor";
            this.RESE_AUTOR.FieldName = "RESE_AUTOR";
            this.RESE_AUTOR.Name = "RESE_AUTOR";
            this.RESE_AUTOR.Visible = true;
            this.RESE_AUTOR.VisibleIndex = 4;
            // 
            // RESE_EDITORIAL
            // 
            this.RESE_EDITORIAL.Caption = "Editorial";
            this.RESE_EDITORIAL.FieldName = "RESE_EDITORIAL";
            this.RESE_EDITORIAL.MaxWidth = 80;
            this.RESE_EDITORIAL.MinWidth = 80;
            this.RESE_EDITORIAL.Name = "RESE_EDITORIAL";
            this.RESE_EDITORIAL.Visible = true;
            this.RESE_EDITORIAL.VisibleIndex = 5;
            this.RESE_EDITORIAL.Width = 80;
            // 
            // RESE_PRECIO
            // 
            this.RESE_PRECIO.Caption = "Precio";
            this.RESE_PRECIO.FieldName = "RESE_PRECIO";
            this.RESE_PRECIO.Name = "RESE_PRECIO";
            this.RESE_PRECIO.Visible = true;
            this.RESE_PRECIO.VisibleIndex = 6;
            this.RESE_PRECIO.Width = 59;
            // 
            // RESE_CANTIDAD
            // 
            this.RESE_CANTIDAD.Caption = "Cantidad";
            this.RESE_CANTIDAD.FieldName = "RESE_CANTIDAD";
            this.RESE_CANTIDAD.Name = "RESE_CANTIDAD";
            this.RESE_CANTIDAD.Visible = true;
            this.RESE_CANTIDAD.VisibleIndex = 7;
            // 
            // RESE_FECHA
            // 
            this.RESE_FECHA.Caption = "Fecha";
            this.RESE_FECHA.FieldName = "RESE_FECHA";
            this.RESE_FECHA.MaxWidth = 70;
            this.RESE_FECHA.MinWidth = 70;
            this.RESE_FECHA.Name = "RESE_FECHA";
            this.RESE_FECHA.Visible = true;
            this.RESE_FECHA.VisibleIndex = 8;
            this.RESE_FECHA.Width = 70;
            // 
            // RESE_IDE
            // 
            this.RESE_IDE.Caption = "RESE_IDE";
            this.RESE_IDE.FieldName = "RESE_IDE";
            this.RESE_IDE.Name = "RESE_IDE";
            // 
            // Cargado
            // 
            this.Cargado.Caption = "Cargado";
            this.Cargado.FieldName = "Cargado";
            this.Cargado.Name = "Cargado";
            this.Cargado.Visible = true;
            this.Cargado.VisibleIndex = 9;
            // 
            // paraavisar
            // 
            this.paraavisar.Caption = "Para_avisar";
            this.paraavisar.FieldName = "paraavisar";
            this.paraavisar.Name = "paraavisar";
            this.paraavisar.Visible = true;
            this.paraavisar.VisibleIndex = 10;
            // 
            // Avisado
            // 
            this.Avisado.Caption = "Avisado";
            this.Avisado.FieldName = "Avisado";
            this.Avisado.Name = "Avisado";
            this.Avisado.Visible = true;
            this.Avisado.VisibleIndex = 11;
            // 
            // Entregado
            // 
            this.Entregado.Caption = "Entregado";
            this.Entregado.FieldName = "Entregado";
            this.Entregado.Name = "Entregado";
            this.Entregado.Visible = true;
            this.Entregado.VisibleIndex = 12;
            // 
            // RESE_ESTADO
            // 
            this.RESE_ESTADO.Caption = "RESE_ESTADO";
            this.RESE_ESTADO.FieldName = "RESE_ESTADO";
            this.RESE_ESTADO.Name = "RESE_ESTADO";
            // 
            // RESE_CLIE_IDE
            // 
            this.RESE_CLIE_IDE.Caption = "RESE_CLIE_IDE";
            this.RESE_CLIE_IDE.FieldName = "RESE_CLIE_IDE";
            this.RESE_CLIE_IDE.Name = "RESE_CLIE_IDE";
            this.RESE_CLIE_IDE.Visible = true;
            this.RESE_CLIE_IDE.VisibleIndex = 13;
            // 
            // Alaventa
            // 
            this.Alaventa.Caption = "Alaventa";
            this.Alaventa.FieldName = "Alaventa";
            this.Alaventa.Name = "Alaventa";
            // 
            // RESE_USUV_FE
            // 
            this.RESE_USUV_FE.Caption = "RESE_USUV_FE";
            this.RESE_USUV_FE.FieldName = "RESE_USUV_FE";
            this.RESE_USUV_FE.Name = "RESE_USUV_FE";
            // 
            // RESE_OBS
            // 
            this.RESE_OBS.Caption = "RESE_OBS";
            this.RESE_OBS.FieldName = "RESE_OBS";
            this.RESE_OBS.MaxWidth = 100;
            this.RESE_OBS.MinWidth = 100;
            this.RESE_OBS.Name = "RESE_OBS";
            this.RESE_OBS.Visible = true;
            this.RESE_OBS.VisibleIndex = 14;
            this.RESE_OBS.Width = 100;
            // 
            // RESE_USUP_FE
            // 
            this.RESE_USUP_FE.Caption = "RESE_USUP_FE";
            this.RESE_USUP_FE.FieldName = "RESE_USUP_FE";
            this.RESE_USUP_FE.MaxWidth = 50;
            this.RESE_USUP_FE.MinWidth = 50;
            this.RESE_USUP_FE.Name = "RESE_USUP_FE";
            this.RESE_USUP_FE.Visible = true;
            this.RESE_USUP_FE.VisibleIndex = 15;
            this.RESE_USUP_FE.Width = 50;
            // 
            // usumodificar
            // 
            this.usumodificar.Caption = "usumodificar";
            this.usumodificar.FieldName = "usumodificar";
            this.usumodificar.Name = "usumodificar";
            // 
            // RESE_USUM_FE
            // 
            this.RESE_USUM_FE.Caption = "RESE_USUM_FE";
            this.RESE_USUM_FE.FieldName = "RESE_USUM_FE";
            this.RESE_USUM_FE.Name = "RESE_USUM_FE";
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.Cancel64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(853, 386);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 87);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::Presentacion.Properties.Resources.editar641;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.Location = new System.Drawing.Point(473, 382);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(102, 87);
            this.btnmodificar.TabIndex = 11;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnparaavisar
            // 
            this.btnparaavisar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnparaavisar.Location = new System.Drawing.Point(49, 401);
            this.btnparaavisar.Name = "btnparaavisar";
            this.btnparaavisar.Size = new System.Drawing.Size(108, 21);
            this.btnparaavisar.TabIndex = 22;
            this.btnparaavisar.Text = "Para avisar";
            this.btnparaavisar.UseVisualStyleBackColor = false;
            this.btnparaavisar.Click += new System.EventHandler(this.btnparaavisar_Click);
            // 
            // btnavisado
            // 
            this.btnavisado.BackColor = System.Drawing.Color.LightYellow;
            this.btnavisado.Location = new System.Drawing.Point(49, 431);
            this.btnavisado.Name = "btnavisado";
            this.btnavisado.Size = new System.Drawing.Size(108, 21);
            this.btnavisado.TabIndex = 23;
            this.btnavisado.Text = "Avisado";
            this.btnavisado.UseVisualStyleBackColor = false;
            this.btnavisado.Click += new System.EventHandler(this.btnavisado_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(163, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 21);
            this.button4.TabIndex = 24;
            this.button4.Text = "Entregado";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnalaventa
            // 
            this.btnalaventa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnalaventa.Location = new System.Drawing.Point(163, 431);
            this.btnalaventa.Name = "btnalaventa";
            this.btnalaventa.Size = new System.Drawing.Size(108, 21);
            this.btnalaventa.TabIndex = 25;
            this.btnalaventa.Text = "A la venta";
            this.btnalaventa.UseVisualStyleBackColor = false;
            this.btnalaventa.Click += new System.EventHandler(this.btnalaventa_Click);
            // 
            // btntodos
            // 
            this.btntodos.BackColor = System.Drawing.Color.White;
            this.btntodos.Location = new System.Drawing.Point(277, 401);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(108, 21);
            this.btntodos.TabIndex = 26;
            this.btntodos.Text = "Todos";
            this.btntodos.UseVisualStyleBackColor = false;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // ConsultaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 476);
            this.ControlBox = false;
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btnalaventa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnavisado);
            this.Controls.Add(this.btnparaavisar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.gConsulta);
            this.Name = "ConsultaReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Reservas";
            this.Load += new System.EventHandler(this.ConsultaInteres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPintarFilas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPintarFilas;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_NOMBRE;
        private DevExpress.XtraGrid.Columns.GridColumn CLIEN_TELEFONO;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_LI_CODIGOVIEJO;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_EDITORIAL;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_PRECIO;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_FECHA;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn Cargado;
        private DevExpress.XtraGrid.Columns.GridColumn paraavisar;
        private DevExpress.XtraGrid.Columns.GridColumn Avisado;
        private DevExpress.XtraGrid.Columns.GridColumn Entregado;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_ESTADO;
        private System.Windows.Forms.Button btnparaavisar;
        private System.Windows.Forms.Button btnavisado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnalaventa;
        private System.Windows.Forms.Button btntodos;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_AUTOR;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_CANTIDAD;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_CLIE_IDE;
        private DevExpress.XtraGrid.Columns.GridColumn Alaventa;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUV_FE;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_OBS;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUP_FE;
        private DevExpress.XtraGrid.Columns.GridColumn usumodificar;
        private DevExpress.XtraGrid.Columns.GridColumn RESE_USUM_FE;
    }
}