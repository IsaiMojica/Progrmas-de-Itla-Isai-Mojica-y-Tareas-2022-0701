namespace Programa_5._4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarVentana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentana2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVentana1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarVentana1ToolStripMenuItem
            // 
            this.adicionarVentana1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVentana2ToolStripMenuItem,
            this.adicionarVentana2ToolStripMenuItem1});
            this.adicionarVentana1ToolStripMenuItem.Name = "adicionarVentana1ToolStripMenuItem";
            this.adicionarVentana1ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.adicionarVentana1ToolStripMenuItem.Text = "Ventana";
            // 
            // adicionarVentana2ToolStripMenuItem
            // 
            this.adicionarVentana2ToolStripMenuItem.Name = "adicionarVentana2ToolStripMenuItem";
            this.adicionarVentana2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarVentana2ToolStripMenuItem.Text = "Adicionar ventana 1";
            this.adicionarVentana2ToolStripMenuItem.Click += new System.EventHandler(this.adicionarVentana2ToolStripMenuItem_Click);
            // 
            // adicionarVentana2ToolStripMenuItem1
            // 
            this.adicionarVentana2ToolStripMenuItem1.Name = "adicionarVentana2ToolStripMenuItem1";
            this.adicionarVentana2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.adicionarVentana2ToolStripMenuItem1.Text = "Adicionar ventana 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana2ToolStripMenuItem1;
    }
}

