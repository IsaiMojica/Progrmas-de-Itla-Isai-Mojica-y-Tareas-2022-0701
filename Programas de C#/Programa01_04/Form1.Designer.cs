namespace Programa01_04
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
            chkMonitor = new CheckBox();
            ChkTeclado = new CheckBox();
            ChkMouse = new CheckBox();
            lblMensaje = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // chkMonitor
            // 
            chkMonitor.AutoSize = true;
            chkMonitor.Location = new Point(55, 65);
            chkMonitor.Name = "chkMonitor";
            chkMonitor.Size = new Size(124, 24);
            chkMonitor.TabIndex = 0;
            chkMonitor.Text = "Monitor  S250";
            chkMonitor.UseVisualStyleBackColor = true;
            chkMonitor.CheckedChanged += chkMonitor_CheckedChanged;
            // 
            // ChkTeclado
            // 
            ChkTeclado.AutoSize = true;
            ChkTeclado.Location = new Point(55, 118);
            ChkTeclado.Name = "ChkTeclado";
            ChkTeclado.Size = new Size(111, 24);
            ChkTeclado.TabIndex = 1;
            ChkTeclado.Text = "Teclado S15";
            ChkTeclado.UseVisualStyleBackColor = true;
            ChkTeclado.CheckedChanged += ChkTeclado_CheckedChanged;
            // 
            // ChkMouse
            // 
            ChkMouse.AutoSize = true;
            ChkMouse.Location = new Point(55, 162);
            ChkMouse.Name = "ChkMouse";
            ChkMouse.Size = new Size(103, 24);
            ChkMouse.TabIndex = 2;
            ChkMouse.Text = "Mouse S20";
            ChkMouse.UseVisualStyleBackColor = true;
            ChkMouse.CheckedChanged += ChkMouse_CheckedChanged;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(55, 231);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 20);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "lblMensaje";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(254, 60);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 371);
            Controls.Add(btnCalcular);
            Controls.Add(lblMensaje);
            Controls.Add(ChkMouse);
            Controls.Add(ChkTeclado);
            Controls.Add(chkMonitor);
            Name = "Form1";
            Text = "Programa 04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMonitor;
        private CheckBox ChkTeclado;
        private CheckBox ChkMouse;
        private Label lblMensaje;
        private Button btnCalcular;
    }
}