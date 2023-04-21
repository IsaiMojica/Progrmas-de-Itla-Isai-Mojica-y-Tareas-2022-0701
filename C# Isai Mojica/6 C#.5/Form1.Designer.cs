namespace Programa_6._5
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(699, 454);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(13, 13);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(23, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(42, 13);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(23, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(71, 13);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(23, 23);
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.Text = "R";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(100, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "S";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(129, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(23, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "H";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(159, 13);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(447, 20);
            this.txtURL.TabIndex = 6;
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(612, 13);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(23, 23);
            this.btnIr.TabIndex = 7;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 454);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnIr;
    }
}

