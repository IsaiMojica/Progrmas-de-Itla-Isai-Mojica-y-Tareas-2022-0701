namespace Programa02_02
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
            btnSaludo = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(287, 31);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(94, 29);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "Saludo!";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(52, 96);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "label1";
            lblMensaje.Click += lblMensaje_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 231);
            Controls.Add(lblMensaje);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnSaludo);
            Name = "Form1";
            Text = "Programa02";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludo;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblMensaje;
    }
}