namespace Programa_2._4
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
            this.components = new System.ComponentModel.Container();
            this.tmrPrueba = new System.Windows.Forms.Timer(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.trkIntervalo = new System.Windows.Forms.TrackBar();
            this.lblTrkValor = new System.Windows.Forms.Label();
            this.pbTrabajo = new System.Windows.Forms.ProgressBar();
            this.btnCalculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrPrueba
            // 
            this.tmrPrueba.Tick += new System.EventHandler(this.tmrPrueba_Tick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(13, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "label1";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(171, 13);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(171, 42);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // trkIntervalo
            // 
            this.trkIntervalo.Location = new System.Drawing.Point(16, 120);
            this.trkIntervalo.Maximum = 1000;
            this.trkIntervalo.Minimum = 100;
            this.trkIntervalo.Name = "trkIntervalo";
            this.trkIntervalo.Size = new System.Drawing.Size(276, 45);
            this.trkIntervalo.TabIndex = 3;
            this.trkIntervalo.TickFrequency = 100;
            this.trkIntervalo.Value = 100;
            this.trkIntervalo.Scroll += new System.EventHandler(this.trkIntervalo_Scroll);
            // 
            // lblTrkValor
            // 
            this.lblTrkValor.AutoSize = true;
            this.lblTrkValor.Location = new System.Drawing.Point(13, 71);
            this.lblTrkValor.Name = "lblTrkValor";
            this.lblTrkValor.Size = new System.Drawing.Size(35, 13);
            this.lblTrkValor.TabIndex = 4;
            this.lblTrkValor.Text = "label1";
            // 
            // pbTrabajo
            // 
            this.pbTrabajo.Location = new System.Drawing.Point(16, 159);
            this.pbTrabajo.Name = "pbTrabajo";
            this.pbTrabajo.Size = new System.Drawing.Size(276, 23);
            this.pbTrabajo.TabIndex = 5;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(170, 200);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 247);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.pbTrabajo);
            this.Controls.Add(this.lblTrkValor);
            this.Controls.Add(this.trkIntervalo);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trkIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrPrueba;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TrackBar trkIntervalo;
        private System.Windows.Forms.Label lblTrkValor;
        private System.Windows.Forms.ProgressBar pbTrabajo;
        private System.Windows.Forms.Button btnCalculo;
    }
}

