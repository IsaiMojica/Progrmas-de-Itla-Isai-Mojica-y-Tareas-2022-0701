namespace Programa_4._3
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
            this.mtxtDato = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtDato
            // 
            this.mtxtDato.Location = new System.Drawing.Point(13, 13);
            this.mtxtDato.Mask = "00/00/0000";
            this.mtxtDato.Name = "mtxtDato";
            this.mtxtDato.Size = new System.Drawing.Size(100, 20);
            this.mtxtDato.TabIndex = 0;
            this.mtxtDato.ValidatingType = typeof(System.DateTime);
            this.mtxtDato.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDato_MaskInputRejected);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(151, 13);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(13, 58);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 246);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.mtxtDato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtDato;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblMensaje;
    }
}

