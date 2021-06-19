namespace Presentacion
{
    partial class AltaReserva
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.gBtipopro = new System.Windows.Forms.GroupBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbarra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnnoaparececatalogo = new System.Windows.Forms.Button();
            this.btnbuscacli = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.gBtipopro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(39, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 192;
            this.label3.Text = "Cliente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(69, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 194;
            this.label4.Text = "Teléfono:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcliente.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcliente.Location = new System.Drawing.Point(148, 245);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(194, 24);
            this.txtcliente.TabIndex = 216;
            this.txtcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcliente_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttelefono.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttelefono.Location = new System.Drawing.Point(148, 284);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 24);
            this.txttelefono.TabIndex = 217;
            this.txttelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttelefono_KeyPress);
            // 
            // gBtipopro
            // 
            this.gBtipopro.Controls.Add(this.txttitulo);
            this.gBtipopro.Controls.Add(this.txtcodigo);
            this.gBtipopro.Controls.Add(this.label6);
            this.gBtipopro.Controls.Add(this.txtbarra);
            this.gBtipopro.Controls.Add(this.label12);
            this.gBtipopro.Controls.Add(this.label7);
            this.gBtipopro.Location = new System.Drawing.Point(25, 6);
            this.gBtipopro.Name = "gBtipopro";
            this.gBtipopro.Size = new System.Drawing.Size(433, 140);
            this.gBtipopro.TabIndex = 222;
            this.gBtipopro.TabStop = false;
            this.gBtipopro.Text = "Buscar el producto para agregar...";
            // 
            // txttitulo
            // 
            this.txttitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txttitulo.Enabled = false;
            this.txttitulo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txttitulo.Location = new System.Drawing.Point(18, 96);
            this.txttitulo.MaxLength = 60;
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(390, 21);
            this.txttitulo.TabIndex = 225;
            this.txttitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttitulo_KeyPress);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtcodigo.Location = new System.Drawing.Point(329, 26);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(79, 24);
            this.txtcodigo.TabIndex = 221;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(267, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 222;
            this.label6.Text = "Código:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbarra
            // 
            this.txtbarra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbarra.Enabled = false;
            this.txtbarra.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtbarra.Location = new System.Drawing.Point(84, 26);
            this.txtbarra.Name = "txtbarra";
            this.txtbarra.Size = new System.Drawing.Size(156, 24);
            this.txtbarra.TabIndex = 218;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Location = new System.Drawing.Point(12, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 220;
            this.label12.Text = "BARRA:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(23, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 187;
            this.label7.Text = "Título:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(91, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 187;
            this.label1.Text = "Autor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtautor
            // 
            this.txtautor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtautor.Enabled = false;
            this.txtautor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtautor.Location = new System.Drawing.Point(148, 167);
            this.txtautor.MaxLength = 60;
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(195, 24);
            this.txtautor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(74, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 190;
            this.label2.Text = "Editorial:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txteditorial
            // 
            this.txteditorial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txteditorial.Enabled = false;
            this.txteditorial.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditorial.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txteditorial.Location = new System.Drawing.Point(148, 206);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(194, 24);
            this.txteditorial.TabIndex = 1;
            this.txteditorial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtautor_KeyPress);
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtprecio.Enabled = false;
            this.txtprecio.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtprecio.Location = new System.Drawing.Point(334, 284);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(77, 24);
            this.txtprecio.TabIndex = 224;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(277, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 223;
            this.label8.Text = "Precio:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnnoaparececatalogo
            // 
            this.btnnoaparececatalogo.Image = global::Presentacion.Properties.Resources.nolibro32;
            this.btnnoaparececatalogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnoaparececatalogo.Location = new System.Drawing.Point(384, 168);
            this.btnnoaparececatalogo.Name = "btnnoaparececatalogo";
            this.btnnoaparececatalogo.Size = new System.Drawing.Size(75, 66);
            this.btnnoaparececatalogo.TabIndex = 227;
            this.btnnoaparececatalogo.Text = "No aparece en catálogo";
            this.btnnoaparececatalogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnoaparececatalogo.UseVisualStyleBackColor = true;
            this.btnnoaparececatalogo.Click += new System.EventHandler(this.btnnoaparececatalogo_Click);
            // 
            // btnbuscacli
            // 
            this.btnbuscacli.Image = global::Presentacion.Properties.Resources.buscarlibro32;
            this.btnbuscacli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscacli.Location = new System.Drawing.Point(97, 235);
            this.btnbuscacli.Name = "btnbuscacli";
            this.btnbuscacli.Size = new System.Drawing.Size(41, 41);
            this.btnbuscacli.TabIndex = 226;
            this.btnbuscacli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscacli.UseVisualStyleBackColor = true;
            this.btnbuscacli.Click += new System.EventHandler(this.btnbuscacli_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Presentacion.Properties.Resources.cancelar64;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(263, 373);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 79);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Presentacion.Properties.Resources.guardar64;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(121, 373);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 79);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtcantidad.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtcantidad.Location = new System.Drawing.Point(148, 323);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(51, 30);
            this.txtcantidad.TabIndex = 231;
            this.txtcantidad.Text = "1";
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label26.Location = new System.Drawing.Point(67, 329);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 17);
            this.label26.TabIndex = 230;
            this.label26.Text = "Cantidad:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AltaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 457);
            this.ControlBox = false;
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnnoaparececatalogo);
            this.Controls.Add(this.btnbuscacli);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gBtipopro);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txteditorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Name = "AltaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de reserva...";
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            this.gBtipopro.ResumeLayout(false);
            this.gBtipopro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.GroupBox gBtipopro;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbarra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnbuscacli;
        private System.Windows.Forms.Button btnnoaparececatalogo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label26;
    }
}