namespace Programa02_04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensaje = new Label();
            btnForma2 = new Button();
            lblContenido = new Label();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(48, 28);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(139, 20);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "=============";
            // 
            // btnForma2
            // 
            btnForma2.Location = new Point(336, 25);
            btnForma2.Name = "btnForma2";
            btnForma2.Size = new Size(120, 29);
            btnForma2.TabIndex = 1;
            btnForma2.Text = "Abrir Forma2";
            btnForma2.UseVisualStyleBackColor = true;
            btnForma2.Click += btnForma2_Click;
            // 
            // lblContenido
            // 
            lblContenido.AutoSize = true;
            lblContenido.Location = new Point(48, 70);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(50, 20);
            lblContenido.TabIndex = 2;
            lblContenido.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 420);
            Controls.Add(lblContenido);
            Controls.Add(btnForma2);
            Controls.Add(lblMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnForma2;
        private Label lblContenido;
    }
}