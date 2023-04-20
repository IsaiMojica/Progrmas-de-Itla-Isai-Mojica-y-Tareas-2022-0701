namespace Programa01_05
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
            txtA = new TextBox();
            txtB = new TextBox();
            gboxOperaciones = new GroupBox();
            rbDivisión = new RadioButton();
            rbMulti = new RadioButton();
            rbResta = new RadioButton();
            rbSuma = new RadioButton();
            btnCalcular = new Button();
            lblResultado = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            gboxOperaciones.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(12, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 27);
            txtA.TabIndex = 0;
            txtA.Text = "0";
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtB
            // 
            txtB.Location = new Point(12, 45);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 1;
            txtB.Text = "0";
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // gboxOperaciones
            // 
            gboxOperaciones.Controls.Add(rbDivisión);
            gboxOperaciones.Controls.Add(rbMulti);
            gboxOperaciones.Controls.Add(rbResta);
            gboxOperaciones.Controls.Add(rbSuma);
            gboxOperaciones.Location = new Point(12, 135);
            gboxOperaciones.Name = "gboxOperaciones";
            gboxOperaciones.Size = new Size(220, 164);
            gboxOperaciones.TabIndex = 2;
            gboxOperaciones.TabStop = false;
            gboxOperaciones.Text = "Operaciones";
            // 
            // rbDivisión
            // 
            rbDivisión.AutoSize = true;
            rbDivisión.Location = new Point(6, 116);
            rbDivisión.Name = "rbDivisión";
            rbDivisión.Size = new Size(83, 24);
            rbDivisión.TabIndex = 3;
            rbDivisión.Text = "División";
            rbDivisión.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            rbMulti.AutoSize = true;
            rbMulti.Location = new Point(6, 86);
            rbMulti.Name = "rbMulti";
            rbMulti.Size = new Size(124, 24);
            rbMulti.TabIndex = 2;
            rbMulti.Text = "Multiplicación";
            rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            rbResta.AutoSize = true;
            rbResta.Location = new Point(6, 56);
            rbResta.Name = "rbResta";
            rbResta.Size = new Size(66, 24);
            rbResta.TabIndex = 1;
            rbResta.Text = "Resta";
            rbResta.UseVisualStyleBackColor = true;
            // 
            // rbSuma
            // 
            rbSuma.AutoSize = true;
            rbSuma.Checked = true;
            rbSuma.Location = new Point(6, 26);
            rbSuma.Name = "rbSuma";
            rbSuma.Size = new Size(67, 24);
            rbSuma.TabIndex = 0;
            rbSuma.TabStop = true;
            rbSuma.Text = "Suma";
            rbSuma.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(314, 11);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(18, 89);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(272, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 164);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(10, 116);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(10, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(10, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 314);
            Controls.Add(groupBox1);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(gboxOperaciones);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            gboxOperaciones.ResumeLayout(false);
            gboxOperaciones.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private GroupBox gboxOperaciones;
        private RadioButton rbDivisión;
        private RadioButton rbMulti;
        private RadioButton rbResta;
        private RadioButton rbSuma;
        private Button btnCalcular;
        private Label lblResultado;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}