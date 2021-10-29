
namespace DesafioElectrodomesticosWF
{
    partial class form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtElectrodomestico = new System.Windows.Forms.RadioButton();
            this.rdtTelevisor = new System.Windows.Forms.RadioButton();
            this.rdtLavadora = new System.Windows.Forms.RadioButton();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblCarga = new System.Windows.Forms.Label();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPulgadas = new System.Windows.Forms.Label();
            this.chbSintonizador = new System.Windows.Forms.CheckBox();
            this.lblElectro = new System.Windows.Forms.Label();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblLavadora = new System.Windows.Forms.Label();
            this.txtTotalElectro = new System.Windows.Forms.Label();
            this.txtTotalLavadora = new System.Windows.Forms.Label();
            this.txtTotalTele = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblPesosElectro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(45, 114);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(269, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Seleccione el obtejo que desea comprar ";
            // 
            // rbtElectrodomestico
            // 
            this.rbtElectrodomestico.AutoSize = true;
            this.rbtElectrodomestico.Location = new System.Drawing.Point(93, 49);
            this.rbtElectrodomestico.Name = "rbtElectrodomestico";
            this.rbtElectrodomestico.Size = new System.Drawing.Size(106, 17);
            this.rbtElectrodomestico.TabIndex = 2;
            this.rbtElectrodomestico.TabStop = true;
            this.rbtElectrodomestico.Text = "Electrodoméstico";
            this.rbtElectrodomestico.UseVisualStyleBackColor = true;
            this.rbtElectrodomestico.CheckedChanged += new System.EventHandler(this.rbtElectrodomestico_CheckedChanged);
            // 
            // rdtTelevisor
            // 
            this.rdtTelevisor.AutoSize = true;
            this.rdtTelevisor.Location = new System.Drawing.Point(524, 49);
            this.rdtTelevisor.Name = "rdtTelevisor";
            this.rdtTelevisor.Size = new System.Drawing.Size(68, 17);
            this.rdtTelevisor.TabIndex = 3;
            this.rdtTelevisor.TabStop = true;
            this.rdtTelevisor.Text = "Televisor";
            this.rdtTelevisor.UseVisualStyleBackColor = true;
            this.rdtTelevisor.CheckedChanged += new System.EventHandler(this.rdtTelevisor_CheckedChanged);
            // 
            // rdtLavadora
            // 
            this.rdtLavadora.AutoSize = true;
            this.rdtLavadora.Location = new System.Drawing.Point(328, 49);
            this.rdtLavadora.Name = "rdtLavadora";
            this.rdtLavadora.Size = new System.Drawing.Size(70, 17);
            this.rdtLavadora.TabIndex = 4;
            this.rdtLavadora.TabStop = true;
            this.rdtLavadora.Text = "Lavadora";
            this.rdtLavadora.UseVisualStyleBackColor = true;
            this.rdtLavadora.CheckedChanged += new System.EventHandler(this.rdtLavadora_CheckedChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(42, 89);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(183, 89);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(105, 13);
            this.lblConsumo.TabIndex = 7;
            this.lblConsumo.Text = "Consumo Energético";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(186, 114);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 6;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(42, 149);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(45, 174);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 8;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(185, 149);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 11;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(188, 174);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 10;
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Location = new System.Drawing.Point(325, 89);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(35, 13);
            this.lblCarga.TabIndex = 15;
            this.lblCarga.Text = "Carga";
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(328, 114);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(100, 20);
            this.txtCarga.TabIndex = 14;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Location = new System.Drawing.Point(595, 89);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(60, 13);
            this.lblResolucion.TabIndex = 17;
            this.lblResolucion.Text = "Resolución";
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(598, 114);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(100, 20);
            this.txtResolucion.TabIndex = 16;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(284, 89);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(29, 13);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "(A-F)";
            // 
            // lblPulgadas
            // 
            this.lblPulgadas.AutoSize = true;
            this.lblPulgadas.Location = new System.Drawing.Point(652, 89);
            this.lblPulgadas.Name = "lblPulgadas";
            this.lblPulgadas.Size = new System.Drawing.Size(56, 13);
            this.lblPulgadas.TabIndex = 23;
            this.lblPulgadas.Text = "(pulgadas)";
            // 
            // chbSintonizador
            // 
            this.chbSintonizador.AutoSize = true;
            this.chbSintonizador.Location = new System.Drawing.Point(480, 114);
            this.chbSintonizador.Name = "chbSintonizador";
            this.chbSintonizador.Size = new System.Drawing.Size(109, 17);
            this.chbSintonizador.TabIndex = 24;
            this.chbSintonizador.Text = "Sintonizador TTD";
            this.chbSintonizador.UseVisualStyleBackColor = true;
            // 
            // lblElectro
            // 
            this.lblElectro.AutoSize = true;
            this.lblElectro.Location = new System.Drawing.Point(62, 307);
            this.lblElectro.Name = "lblElectro";
            this.lblElectro.Size = new System.Drawing.Size(119, 13);
            this.lblElectro.TabIndex = 25;
            this.lblElectro.Text = "Total electrodomésticos";
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Location = new System.Drawing.Point(557, 307);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(84, 13);
            this.lblTele.TabIndex = 26;
            this.lblTele.Text = "Total televisores";
            // 
            // lblLavadora
            // 
            this.lblLavadora.AutoSize = true;
            this.lblLavadora.Location = new System.Drawing.Point(303, 307);
            this.lblLavadora.Name = "lblLavadora";
            this.lblLavadora.Size = new System.Drawing.Size(80, 13);
            this.lblLavadora.TabIndex = 27;
            this.lblLavadora.Text = "Total lavadoras";
            // 
            // txtTotalElectro
            // 
            this.txtTotalElectro.AutoSize = true;
            this.txtTotalElectro.Location = new System.Drawing.Point(79, 337);
            this.txtTotalElectro.Name = "txtTotalElectro";
            this.txtTotalElectro.Size = new System.Drawing.Size(13, 13);
            this.txtTotalElectro.TabIndex = 31;
            this.txtTotalElectro.Text = "0";
            // 
            // txtTotalLavadora
            // 
            this.txtTotalLavadora.AutoSize = true;
            this.txtTotalLavadora.Location = new System.Drawing.Point(325, 337);
            this.txtTotalLavadora.Name = "txtTotalLavadora";
            this.txtTotalLavadora.Size = new System.Drawing.Size(13, 13);
            this.txtTotalLavadora.TabIndex = 32;
            this.txtTotalLavadora.Text = "0";
            // 
            // txtTotalTele
            // 
            this.txtTotalTele.AutoSize = true;
            this.txtTotalTele.Location = new System.Drawing.Point(576, 337);
            this.txtTotalTele.Name = "txtTotalTele";
            this.txtTotalTele.Size = new System.Drawing.Size(13, 13);
            this.txtTotalTele.TabIndex = 33;
            this.txtTotalTele.Text = "0";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(328, 260);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 34;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblPesosElectro
            // 
            this.lblPesosElectro.AutoSize = true;
            this.lblPesosElectro.Location = new System.Drawing.Point(60, 337);
            this.lblPesosElectro.Name = "lblPesosElectro";
            this.lblPesosElectro.Size = new System.Drawing.Size(13, 13);
            this.lblPesosElectro.TabIndex = 36;
            this.lblPesosElectro.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "$";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPesosElectro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtTotalTele);
            this.Controls.Add(this.txtTotalLavadora);
            this.Controls.Add(this.txtTotalElectro);
            this.Controls.Add(this.lblLavadora);
            this.Controls.Add(this.lblTele);
            this.Controls.Add(this.lblElectro);
            this.Controls.Add(this.chbSintonizador);
            this.Controls.Add(this.lblPulgadas);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.txtResolucion);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.txtCarga);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.rdtLavadora);
            this.Controls.Add(this.rdtTelevisor);
            this.Controls.Add(this.rbtElectrodomestico);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPrecio);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtElectrodomestico;
        private System.Windows.Forms.RadioButton rdtTelevisor;
        private System.Windows.Forms.RadioButton rdtLavadora;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblPulgadas;
        private System.Windows.Forms.CheckBox chbSintonizador;
        private System.Windows.Forms.Label lblElectro;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblLavadora;
        private System.Windows.Forms.Label txtTotalElectro;
        private System.Windows.Forms.Label txtTotalLavadora;
        private System.Windows.Forms.Label txtTotalTele;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblPesosElectro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

