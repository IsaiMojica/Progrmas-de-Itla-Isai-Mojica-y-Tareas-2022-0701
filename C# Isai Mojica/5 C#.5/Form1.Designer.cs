namespace Programa_5._5
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
            this.btnDibuja = new System.Windows.Forms.Button();
            this.btnInvalidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDibuja
            // 
            this.btnDibuja.Location = new System.Drawing.Point(460, 26);
            this.btnDibuja.Name = "btnDibuja";
            this.btnDibuja.Size = new System.Drawing.Size(75, 23);
            this.btnDibuja.TabIndex = 0;
            this.btnDibuja.Text = "Dibuja";
            this.btnDibuja.UseVisualStyleBackColor = true;
            this.btnDibuja.Click += new System.EventHandler(this.btnDibuja_Click);
            // 
            // btnInvalidate
            // 
            this.btnInvalidate.Location = new System.Drawing.Point(460, 55);
            this.btnInvalidate.Name = "btnInvalidate";
            this.btnInvalidate.Size = new System.Drawing.Size(75, 23);
            this.btnInvalidate.TabIndex = 1;
            this.btnInvalidate.Text = "Invalidate";
            this.btnInvalidate.UseVisualStyleBackColor = true;
            this.btnInvalidate.Click += new System.EventHandler(this.btnInvalidate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 307);
            this.Controls.Add(this.btnInvalidate);
            this.Controls.Add(this.btnDibuja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDibuja;
        private System.Windows.Forms.Button btnInvalidate;
    }
}

