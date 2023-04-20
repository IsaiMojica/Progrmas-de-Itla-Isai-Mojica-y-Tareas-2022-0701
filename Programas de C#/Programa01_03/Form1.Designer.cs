namespace Programa01_03
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
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            lblResultado = new Label();
            btnSuma = new Button();
            lblResta = new Button();
            lblDivisión = new Button();
            lblMultiplicación = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(39, 48);
            lblA.Name = "lblA";
            lblA.Size = new Size(22, 20);
            lblA.TabIndex = 0;
            lblA.Text = "A:";
            // 
            // txtA
            // 
            txtA.Location = new Point(67, 47);
            txtA.Name = "txtA";
            txtA.Size = new Size(191, 27);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(38, 109);
            lblB.Name = "lblB";
            lblB.Size = new Size(21, 20);
            lblB.TabIndex = 2;
            lblB.Text = "B:";
            // 
            // txtB
            // 
            txtB.Location = new Point(67, 104);
            txtB.Name = "txtB";
            txtB.Size = new Size(191, 27);
            txtB.TabIndex = 3;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(195, 153);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label1";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(296, 43);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(40, 31);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // lblResta
            // 
            lblResta.Location = new Point(351, 43);
            lblResta.Name = "lblResta";
            lblResta.Size = new Size(36, 31);
            lblResta.TabIndex = 6;
            lblResta.Text = "-";
            lblResta.UseVisualStyleBackColor = true;
            lblResta.Click += lblResta_Click;
            // 
            // lblDivisión
            // 
            lblDivisión.Location = new Point(351, 102);
            lblDivisión.Name = "lblDivisión";
            lblDivisión.Size = new Size(36, 31);
            lblDivisión.TabIndex = 8;
            lblDivisión.Text = "/";
            lblDivisión.UseVisualStyleBackColor = true;
            lblDivisión.Click += lblDivisión_Click;
            // 
            // lblMultiplicación
            // 
            lblMultiplicación.Location = new Point(296, 102);
            lblMultiplicación.Name = "lblMultiplicación";
            lblMultiplicación.Size = new Size(40, 31);
            lblMultiplicación.TabIndex = 7;
            lblMultiplicación.Text = "*";
            lblMultiplicación.UseVisualStyleBackColor = true;
            lblMultiplicación.Click += lblMultiplicación_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 224);
            Controls.Add(lblDivisión);
            Controls.Add(lblMultiplicación);
            Controls.Add(lblResta);
            Controls.Add(btnSuma);
            Controls.Add(lblResultado);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Programa03";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private TextBox txtB;
        private Label lblResultado;
        private Button btnSuma;
        private Button lblResta;
        private Button lblDivisión;
        private Button lblMultiplicación;
    }
}