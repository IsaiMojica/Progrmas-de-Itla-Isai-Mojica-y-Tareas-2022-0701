namespace Programa_1._10
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnForma2 = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(13, 13);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(151, 13);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "========================";
            // 
            // btnForma2
            // 
            this.btnForma2.Location = new System.Drawing.Point(231, 13);
            this.btnForma2.Name = "btnForma2";
            this.btnForma2.Size = new System.Drawing.Size(86, 23);
            this.btnForma2.TabIndex = 1;
            this.btnForma2.Text = "Abrir Forma 2";
            this.btnForma2.UseVisualStyleBackColor = true;
            this.btnForma2.Click += new System.EventHandler(this.btnForma2_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(13, 57);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(35, 13);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 264);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnForma2);
            this.Controls.Add(this.lblMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnForma2;
        private System.Windows.Forms.Label lblContenido;
    }
}

