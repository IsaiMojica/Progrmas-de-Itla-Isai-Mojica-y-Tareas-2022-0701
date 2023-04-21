namespace Programa_4._4
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnFechas = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 4, 26, 0, 0, 0, 0)};
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.MonthlyBoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 4, 10, 0, 0, 0, 0)};
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(57, 193);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(35, 13);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "label1";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(60, 238);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(35, 13);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "label1";
            // 
            // btnFechas
            // 
            this.btnFechas.Location = new System.Drawing.Point(377, 214);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(136, 23);
            this.btnFechas.TabIndex = 3;
            this.btnFechas.Text = "Seleccionar fechas";
            this.btnFechas.UseVisualStyleBackColor = true;
            this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(60, 270);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(35, 13);
            this.lblSeleccion.TabIndex = 4;
            this.lblSeleccion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 428);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Label lblSeleccion;
    }
}

