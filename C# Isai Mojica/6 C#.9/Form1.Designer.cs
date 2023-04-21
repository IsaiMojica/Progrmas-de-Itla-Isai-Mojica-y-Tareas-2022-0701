namespace Programa_6._9
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
            this.ncContro1 = new Programa_6._9.NCContro();
            this.ncContro2 = new Programa_6._9.NCContro();
            this.SuspendLayout();
            // 
            // ncContro1
            // 
            this.ncContro1.Location = new System.Drawing.Point(25, 34);
            this.ncContro1.Name = "ncContro1";
            this.ncContro1.Size = new System.Drawing.Size(75, 29);
            this.ncContro1.TabIndex = 0;
            this.ncContro1.Text = "ncContro1";
            this.ncContro1.UseVisualStyleBackColor = true;
            // 
            // ncContro2
            // 
            this.ncContro2.Location = new System.Drawing.Point(57, 187);
            this.ncContro2.Name = "ncContro2";
            this.ncContro2.Size = new System.Drawing.Size(192, 75);
            this.ncContro2.TabIndex = 1;
            this.ncContro2.Text = "Click aqui";
            this.ncContro2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 322);
            this.Controls.Add(this.ncContro2);
            this.Controls.Add(this.ncContro1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NCContro ncContro1;
        private NCContro ncContro2;
    }
}

