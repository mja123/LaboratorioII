
namespace DesafioFinal
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbTipoPrenda = new System.Windows.Forms.GroupBox();
            this.rdbPants = new System.Windows.Forms.RadioButton();
            this.rdbShirt = new System.Windows.Forms.RadioButton();
            this.ckbShortPants = new System.Windows.Forms.CheckBox();
            this.ckbshirtSleeve = new System.Windows.Forms.CheckBox();
            this.gpbCalidad = new System.Windows.Forms.GroupBox();
            this.rdbPremium = new System.Windows.Forms.RadioButton();
            this.rdbStandard = new System.Windows.Forms.RadioButton();
            this.gpbCantidad = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.gpbPrecio = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnFinalPrice = new System.Windows.Forms.Button();
            this.gpbTipoPrenda.SuspendLayout();
            this.gpbCalidad.SuspendLayout();
            this.gpbCantidad.SuspendLayout();
            this.gpbPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VENTAS AL POR MAYOR - PradBit";
            // 
            // gpbTipoPrenda
            // 
            this.gpbTipoPrenda.Controls.Add(this.rdbPants);
            this.gpbTipoPrenda.Controls.Add(this.rdbShirt);
            this.gpbTipoPrenda.Controls.Add(this.ckbShortPants);
            this.gpbTipoPrenda.Controls.Add(this.ckbshirtSleeve);
            this.gpbTipoPrenda.Location = new System.Drawing.Point(23, 56);
            this.gpbTipoPrenda.Name = "gpbTipoPrenda";
            this.gpbTipoPrenda.Size = new System.Drawing.Size(178, 89);
            this.gpbTipoPrenda.TabIndex = 2;
            this.gpbTipoPrenda.TabStop = false;
            this.gpbTipoPrenda.Text = "Tipo de Prenda";
            // 
            // rdbPants
            // 
            this.rdbPants.AutoSize = true;
            this.rdbPants.Location = new System.Drawing.Point(7, 53);
            this.rdbPants.Name = "rdbPants";
            this.rdbPants.Size = new System.Drawing.Size(67, 17);
            this.rdbPants.TabIndex = 3;
            this.rdbPants.TabStop = true;
            this.rdbPants.Text = "Pantalón";
            this.rdbPants.UseVisualStyleBackColor = true;
            this.rdbPants.CheckedChanged += new System.EventHandler(this.rdbPantalon_CheckedChanged);
            // 
            // rdbShirt
            // 
            this.rdbShirt.AutoSize = true;
            this.rdbShirt.Location = new System.Drawing.Point(7, 29);
            this.rdbShirt.Name = "rdbShirt";
            this.rdbShirt.Size = new System.Drawing.Size(59, 17);
            this.rdbShirt.TabIndex = 2;
            this.rdbShirt.TabStop = true;
            this.rdbShirt.Text = "Camisa";
            this.rdbShirt.UseVisualStyleBackColor = true;
            this.rdbShirt.CheckedChanged += new System.EventHandler(this.rdbCamisa_CheckedChanged);
            // 
            // ckbShortPants
            // 
            this.ckbShortPants.AutoSize = true;
            this.ckbShortPants.Location = new System.Drawing.Point(80, 52);
            this.ckbShortPants.Name = "ckbShortPants";
            this.ckbShortPants.Size = new System.Drawing.Size(68, 17);
            this.ckbShortPants.TabIndex = 1;
            this.ckbShortPants.Text = "Bermuda";
            this.ckbShortPants.UseVisualStyleBackColor = true;
            // 
            // ckbshirtSleeve
            // 
            this.ckbshirtSleeve.AutoSize = true;
            this.ckbshirtSleeve.Location = new System.Drawing.Point(80, 29);
            this.ckbshirtSleeve.Name = "ckbshirtSleeve";
            this.ckbshirtSleeve.Size = new System.Drawing.Size(86, 17);
            this.ckbshirtSleeve.TabIndex = 0;
            this.ckbshirtSleeve.Text = "Manga corta";
            this.ckbshirtSleeve.UseVisualStyleBackColor = true;
            // 
            // gpbCalidad
            // 
            this.gpbCalidad.Controls.Add(this.rdbPremium);
            this.gpbCalidad.Controls.Add(this.rdbStandard);
            this.gpbCalidad.Location = new System.Drawing.Point(23, 169);
            this.gpbCalidad.Name = "gpbCalidad";
            this.gpbCalidad.Size = new System.Drawing.Size(178, 62);
            this.gpbCalidad.TabIndex = 3;
            this.gpbCalidad.TabStop = false;
            this.gpbCalidad.Text = "Calidad de prenda";
            // 
            // rdbPremium
            // 
            this.rdbPremium.AutoSize = true;
            this.rdbPremium.Location = new System.Drawing.Point(97, 37);
            this.rdbPremium.Name = "rdbPremium";
            this.rdbPremium.Size = new System.Drawing.Size(65, 17);
            this.rdbPremium.TabIndex = 1;
            this.rdbPremium.TabStop = true;
            this.rdbPremium.Text = "Premium";
            this.rdbPremium.UseVisualStyleBackColor = true;
            // 
            // rdbStandard
            // 
            this.rdbStandard.AutoSize = true;
            this.rdbStandard.Location = new System.Drawing.Point(6, 37);
            this.rdbStandard.Name = "rdbStandard";
            this.rdbStandard.Size = new System.Drawing.Size(68, 17);
            this.rdbStandard.TabIndex = 0;
            this.rdbStandard.TabStop = true;
            this.rdbStandard.Text = "Standard";
            this.rdbStandard.UseVisualStyleBackColor = true;
            // 
            // gpbCantidad
            // 
            this.gpbCantidad.Controls.Add(this.txtCount);
            this.gpbCantidad.Location = new System.Drawing.Point(23, 247);
            this.gpbCantidad.Name = "gpbCantidad";
            this.gpbCantidad.Size = new System.Drawing.Size(77, 49);
            this.gpbCantidad.TabIndex = 4;
            this.gpbCantidad.TabStop = false;
            this.gpbCantidad.Text = "Cantidad";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(7, 20);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(59, 20);
            this.txtCount.TabIndex = 0;
            // 
            // gpbPrecio
            // 
            this.gpbPrecio.Controls.Add(this.txtPrice);
            this.gpbPrecio.Location = new System.Drawing.Point(117, 247);
            this.gpbPrecio.Name = "gpbPrecio";
            this.gpbPrecio.Size = new System.Drawing.Size(84, 49);
            this.gpbPrecio.TabIndex = 5;
            this.gpbPrecio.TabStop = false;
            this.gpbPrecio.Text = "Precio";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(7, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(59, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // btnFinalPrice
            // 
            this.btnFinalPrice.BackColor = System.Drawing.Color.LightGreen;
            this.btnFinalPrice.Location = new System.Drawing.Point(23, 313);
            this.btnFinalPrice.Name = "btnFinalPrice";
            this.btnFinalPrice.Size = new System.Drawing.Size(178, 51);
            this.btnFinalPrice.TabIndex = 6;
            this.btnFinalPrice.Text = "Calcular Precio Final";
            this.btnFinalPrice.UseVisualStyleBackColor = false;
            this.btnFinalPrice.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(223, 382);
            this.Controls.Add(this.btnFinalPrice);
            this.Controls.Add(this.gpbPrecio);
            this.Controls.Add(this.gpbCantidad);
            this.Controls.Add(this.gpbCalidad);
            this.Controls.Add(this.gpbTipoPrenda);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Ventas al p..";
            this.TransparencyKey = System.Drawing.SystemColors.WindowText;
            this.gpbTipoPrenda.ResumeLayout(false);
            this.gpbTipoPrenda.PerformLayout();
            this.gpbCalidad.ResumeLayout(false);
            this.gpbCalidad.PerformLayout();
            this.gpbCantidad.ResumeLayout(false);
            this.gpbCantidad.PerformLayout();
            this.gpbPrecio.ResumeLayout(false);
            this.gpbPrecio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbTipoPrenda;
        private System.Windows.Forms.RadioButton rdbPants;
        private System.Windows.Forms.RadioButton rdbShirt;
        private System.Windows.Forms.CheckBox ckbShortPants;
        private System.Windows.Forms.CheckBox ckbshirtSleeve;
        private System.Windows.Forms.GroupBox gpbCalidad;
        private System.Windows.Forms.RadioButton rdbPremium;
        private System.Windows.Forms.RadioButton rdbStandard;
        private System.Windows.Forms.GroupBox gpbCantidad;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.GroupBox gpbPrecio;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnFinalPrice;
    }
}

