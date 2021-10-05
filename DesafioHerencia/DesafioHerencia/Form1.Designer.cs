
namespace DesafioHerencia
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
            this.gbTipoInmueble = new System.Windows.Forms.GroupBox();
            this.txtVentanas = new System.Windows.Forms.TextBox();
            this.lblVentanas = new System.Windows.Forms.Label();
            this.txtNroPiso = new System.Windows.Forms.TextBox();
            this.lblNroPiso = new System.Windows.Forms.Label();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbPiso = new System.Windows.Forms.RadioButton();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.lblSuperficie = new System.Windows.Forms.Label();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblAnios = new System.Windows.Forms.Label();
            this.gbTipoInmueble.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipoInmueble
            // 
            this.gbTipoInmueble.Controls.Add(this.txtVentanas);
            this.gbTipoInmueble.Controls.Add(this.lblVentanas);
            this.gbTipoInmueble.Controls.Add(this.txtNroPiso);
            this.gbTipoInmueble.Controls.Add(this.lblNroPiso);
            this.gbTipoInmueble.Controls.Add(this.rbLocal);
            this.gbTipoInmueble.Controls.Add(this.rbPiso);
            this.gbTipoInmueble.Location = new System.Drawing.Point(14, 33);
            this.gbTipoInmueble.Name = "gbTipoInmueble";
            this.gbTipoInmueble.Size = new System.Drawing.Size(254, 100);
            this.gbTipoInmueble.TabIndex = 0;
            this.gbTipoInmueble.TabStop = false;
            this.gbTipoInmueble.Text = "Tipo de Inmueble";
            // 
            // txtVentanas
            // 
            this.txtVentanas.Location = new System.Drawing.Point(139, 60);
            this.txtVentanas.Name = "txtVentanas";
            this.txtVentanas.Size = new System.Drawing.Size(51, 20);
            this.txtVentanas.TabIndex = 6;
            // 
            // lblVentanas
            // 
            this.lblVentanas.AutoSize = true;
            this.lblVentanas.Location = new System.Drawing.Point(136, 43);
            this.lblVentanas.Name = "lblVentanas";
            this.lblVentanas.Size = new System.Drawing.Size(87, 13);
            this.lblVentanas.TabIndex = 5;
            this.lblVentanas.Text = "Nro de Ventanas";
            // 
            // txtNroPiso
            // 
            this.txtNroPiso.Location = new System.Drawing.Point(31, 60);
            this.txtNroPiso.Name = "txtNroPiso";
            this.txtNroPiso.Size = new System.Drawing.Size(45, 20);
            this.txtNroPiso.TabIndex = 4;
            // 
            // lblNroPiso
            // 
            this.lblNroPiso.AutoSize = true;
            this.lblNroPiso.Location = new System.Drawing.Point(28, 43);
            this.lblNroPiso.Name = "lblNroPiso";
            this.lblNroPiso.Size = new System.Drawing.Size(47, 13);
            this.lblNroPiso.TabIndex = 3;
            this.lblNroPiso.Text = "Piso Nro";
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(139, 20);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 1;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // rbPiso
            // 
            this.rbPiso.AutoSize = true;
            this.rbPiso.Location = new System.Drawing.Point(15, 20);
            this.rbPiso.Name = "rbPiso";
            this.rbPiso.Size = new System.Drawing.Size(45, 17);
            this.rbPiso.TabIndex = 0;
            this.rbPiso.TabStop = true;
            this.rbPiso.Text = "Piso";
            this.rbPiso.UseVisualStyleBackColor = true;
            this.rbPiso.CheckedChanged += new System.EventHandler(this.rbPiso_CheckedChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 140);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(23, 157);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(245, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(23, 214);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(49, 20);
            this.txtSuperficie.TabIndex = 4;
            // 
            // lblSuperficie
            // 
            this.lblSuperficie.AutoSize = true;
            this.lblSuperficie.Location = new System.Drawing.Point(20, 197);
            this.lblSuperficie.Name = "lblSuperficie";
            this.lblSuperficie.Size = new System.Drawing.Size(54, 13);
            this.lblSuperficie.TabIndex = 3;
            this.lblSuperficie.Text = "Superficie";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(111, 214);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(54, 20);
            this.txtAntiguedad.TabIndex = 6;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(108, 197);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(61, 13);
            this.lblAntiguedad.TabIndex = 5;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(207, 214);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(61, 20);
            this.txtPrecioBase.TabIndex = 8;
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(204, 197);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.lblPrecioBase.TabIndex = 7;
            this.lblPrecioBase.Text = "Precio Base";
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(59, 263);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(165, 37);
            this.btnCalcularPrecio.TabIndex = 9;
            this.btnCalcularPrecio.Text = "Calcular Precio Final";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTotal.Location = new System.Drawing.Point(79, 311);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(78, 221);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(27, 13);
            this.lblMetros.TabIndex = 11;
            this.lblMetros.Text = "(m2)";
            // 
            // lblAnios
            // 
            this.lblAnios.AutoSize = true;
            this.lblAnios.Location = new System.Drawing.Point(171, 221);
            this.lblAnios.Name = "lblAnios";
            this.lblAnios.Size = new System.Drawing.Size(36, 13);
            this.lblAnios.TabIndex = 12;
            this.lblAnios.Text = "(años)";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.lblAnios);
            this.Controls.Add(this.lblMetros);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.lblSuperficie);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.gbTipoInmueble);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "form1";
            this.Text = " Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.gbTipoInmueble.ResumeLayout(false);
            this.gbTipoInmueble.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoInmueble;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbPiso;
        private System.Windows.Forms.TextBox txtVentanas;
        private System.Windows.Forms.Label lblVentanas;
        private System.Windows.Forms.TextBox txtNroPiso;
        private System.Windows.Forms.Label lblNroPiso;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.Label lblSuperficie;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblAnios;
    }
}

