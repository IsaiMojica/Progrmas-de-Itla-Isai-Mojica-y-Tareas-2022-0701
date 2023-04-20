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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblSeguro = new Label();
            rbnBasico = new RadioButton();
            rbnTerceros = new RadioButton();
            rbnTotal = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblEquipo = new Label();
            chkAire = new CheckBox();
            chkAudio = new CheckBox();
            lblCosto = new Label();
            txtCosto = new TextBox();
            btnCotizar = new Button();
            txtCotización = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(70, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(14, 32);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(56, 20);
            lblSeguro.TabIndex = 2;
            lblSeguro.Text = "Seguro";
            // 
            // rbnBasico
            // 
            rbnBasico.AutoSize = true;
            rbnBasico.Checked = true;
            rbnBasico.Location = new Point(160, 30);
            rbnBasico.Name = "rbnBasico";
            rbnBasico.Size = new Size(73, 24);
            rbnBasico.TabIndex = 3;
            rbnBasico.TabStop = true;
            rbnBasico.Text = "Básico";
            rbnBasico.UseVisualStyleBackColor = true;
            // 
            // rbnTerceros
            // 
            rbnTerceros.AutoSize = true;
            rbnTerceros.Location = new Point(160, 60);
            rbnTerceros.Name = "rbnTerceros";
            rbnTerceros.Size = new Size(99, 24);
            rbnTerceros.TabIndex = 4;
            rbnTerceros.Text = "A Terceros";
            rbnTerceros.UseVisualStyleBackColor = true;
            // 
            // rbnTotal
            // 
            rbnTotal.AutoSize = true;
            rbnTotal.Location = new Point(160, 90);
            rbnTotal.Name = "rbnTotal";
            rbnTotal.Size = new Size(63, 24);
            rbnTotal.TabIndex = 5;
            rbnTotal.Text = "Total";
            rbnTotal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnTerceros);
            groupBox1.Controls.Add(rbnTotal);
            groupBox1.Controls.Add(lblSeguro);
            groupBox1.Controls.Add(rbnBasico);
            groupBox1.Location = new Point(54, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 142);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro a seleccionar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkAudio);
            groupBox2.Controls.Add(chkAire);
            groupBox2.Controls.Add(lblEquipo);
            groupBox2.Location = new Point(405, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Equipamiento";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(12, 32);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(56, 20);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            // 
            // chkAire
            // 
            chkAire.AutoSize = true;
            chkAire.Location = new Point(66, 64);
            chkAire.Name = "chkAire";
            chkAire.Size = new Size(161, 24);
            chkAire.TabIndex = 1;
            chkAire.Text = "Aire acondicionado";
            chkAire.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            chkAudio.AutoSize = true;
            chkAudio.Location = new Point(66, 91);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(146, 24);
            chkAudio.TabIndex = 2;
            chkAudio.Text = "Sistema de audio";
            chkAudio.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(71, 264);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(47, 20);
            lblCosto.TabIndex = 8;
            lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(140, 261);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(125, 27);
            txtCosto.TabIndex = 9;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(393, 261);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(94, 29);
            btnCotizar.TabIndex = 10;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // txtCotización
            // 
            txtCotización.Location = new Point(71, 317);
            txtCotización.Multiline = true;
            txtCotización.Name = "txtCotización";
            txtCotización.Size = new Size(584, 163);
            txtCotización.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 503);
            Controls.Add(txtCotización);
            Controls.Add(btnCotizar);
            Controls.Add(txtCosto);
            Controls.Add(lblCosto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblSeguro;
        private RadioButton rbnBasico;
        private RadioButton rbnTerceros;
        private RadioButton rbnTotal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkAudio;
        private CheckBox chkAire;
        private Label lblEquipo;
        private Label lblCosto;
        private TextBox txtCosto;
        private Button btnCotizar;
        private TextBox txtCotización;
    }
}