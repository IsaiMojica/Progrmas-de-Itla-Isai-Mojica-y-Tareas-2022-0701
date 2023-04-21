namespace Programa_5._1
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUva = new System.Windows.Forms.RadioButton();
            this.rbPera = new System.Windows.Forms.RadioButton();
            this.rbManzana = new System.Windows.Forms.RadioButton();
            this.chkImportado = new System.Windows.Forms.CheckBox();
            this.chkOrganico = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(13, 13);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtMensaje.TabIndex = 0;
            this.txtMensaje.TextChanged += new System.EventHandler(this.txtMensaje_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUva);
            this.groupBox1.Controls.Add(this.rbPera);
            this.groupBox1.Controls.Add(this.rbManzana);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbUva
            // 
            this.rbUva.AutoSize = true;
            this.rbUva.Location = new System.Drawing.Point(7, 68);
            this.rbUva.Name = "rbUva";
            this.rbUva.Size = new System.Drawing.Size(45, 17);
            this.rbUva.TabIndex = 2;
            this.rbUva.Text = "Uva";
            this.rbUva.UseVisualStyleBackColor = true;
            this.rbUva.CheckedChanged += new System.EventHandler(this.rbUva_CheckedChanged);
            // 
            // rbPera
            // 
            this.rbPera.AutoSize = true;
            this.rbPera.Location = new System.Drawing.Point(7, 44);
            this.rbPera.Name = "rbPera";
            this.rbPera.Size = new System.Drawing.Size(47, 17);
            this.rbPera.TabIndex = 1;
            this.rbPera.Text = "Pera";
            this.rbPera.UseVisualStyleBackColor = true;
            this.rbPera.CheckedChanged += new System.EventHandler(this.rbPera_CheckedChanged);
            // 
            // rbManzana
            // 
            this.rbManzana.AutoSize = true;
            this.rbManzana.Checked = true;
            this.rbManzana.Location = new System.Drawing.Point(7, 20);
            this.rbManzana.Name = "rbManzana";
            this.rbManzana.Size = new System.Drawing.Size(69, 17);
            this.rbManzana.TabIndex = 0;
            this.rbManzana.TabStop = true;
            this.rbManzana.Text = "Manzana";
            this.rbManzana.UseVisualStyleBackColor = true;
            this.rbManzana.CheckedChanged += new System.EventHandler(this.rbManzana_CheckedChanged);
            // 
            // chkImportado
            // 
            this.chkImportado.AutoSize = true;
            this.chkImportado.Location = new System.Drawing.Point(158, 75);
            this.chkImportado.Name = "chkImportado";
            this.chkImportado.Size = new System.Drawing.Size(73, 17);
            this.chkImportado.TabIndex = 2;
            this.chkImportado.Text = "Importado";
            this.chkImportado.UseVisualStyleBackColor = true;
            this.chkImportado.CheckedChanged += new System.EventHandler(this.chkImportado_CheckedChanged);
            this.chkImportado.CheckStateChanged += new System.EventHandler(this.chkImportado_CheckStateChanged);
            // 
            // chkOrganico
            // 
            this.chkOrganico.AutoSize = true;
            this.chkOrganico.Location = new System.Drawing.Point(158, 99);
            this.chkOrganico.Name = "chkOrganico";
            this.chkOrganico.Size = new System.Drawing.Size(69, 17);
            this.chkOrganico.TabIndex = 3;
            this.chkOrganico.Text = "Organico";
            this.chkOrganico.UseVisualStyleBackColor = true;
            this.chkOrganico.CheckedChanged += new System.EventHandler(this.chkOrganico_CheckedChanged);
            this.chkOrganico.CheckStateChanged += new System.EventHandler(this.chkOrganico_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chkOrganico);
            this.Controls.Add(this.chkImportado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUva;
        private System.Windows.Forms.RadioButton rbPera;
        private System.Windows.Forms.RadioButton rbManzana;
        private System.Windows.Forms.CheckBox chkImportado;
        private System.Windows.Forms.CheckBox chkOrganico;
    }
}

