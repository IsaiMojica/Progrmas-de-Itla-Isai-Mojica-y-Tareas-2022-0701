namespace Programa_2._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtA = new System.Windows.Forms.TextBox();
            this.cmenuTxtA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tstOperaciones = new System.Windows.Forms.ToolStrip();
            this.tstbuttonSuma = new System.Windows.Forms.ToolStripButton();
            this.tstbuttonResta = new System.Windows.Forms.ToolStripButton();
            this.tstbuttonMulti = new System.Windows.Forms.ToolStripButton();
            this.tstbuttonDiv = new System.Windows.Forms.ToolStripButton();
            this.stsInformacion = new System.Windows.Forms.StatusStrip();
            this.slblValores = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblOperacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblResultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.cmenuTxtA.SuspendLayout();
            this.tstOperaciones.SuspendLayout();
            this.stsInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AutoToolTip = true;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Quitar la aplicacion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisionToolStripMenuItem,
            this.toolStripSeparator1,
            this.habilitarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.multiplicacionToolStripMenuItem.Text = "Multiplicacion";
            this.multiplicacionToolStripMenuItem.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.divisionToolStripMenuItem.Text = "Division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Checked = true;
            this.habilitarToolStripMenuItem.CheckOnClick = true;
            this.habilitarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.habilitarToolStripMenuItem_CheckedChanged);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de:";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // txtA
            // 
            this.txtA.ContextMenuStrip = this.cmenuTxtA;
            this.txtA.Location = new System.Drawing.Point(13, 58);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmenuTxtA
            // 
            this.cmenuTxtA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.aleatorioToolStripMenuItem});
            this.cmenuTxtA.Name = "cmenuTxtA";
            this.cmenuTxtA.Size = new System.Drawing.Size(123, 48);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aleatorioToolStripMenuItem.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem.Click += new System.EventHandler(this.aleatorioToolStripMenuItem_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(13, 85);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 2;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(174, 58);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label1";
            // 
            // tstOperaciones
            // 
            this.tstOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbuttonSuma,
            this.tstbuttonResta,
            this.tstbuttonMulti,
            this.tstbuttonDiv});
            this.tstOperaciones.Location = new System.Drawing.Point(0, 24);
            this.tstOperaciones.Name = "tstOperaciones";
            this.tstOperaciones.Size = new System.Drawing.Size(354, 25);
            this.tstOperaciones.TabIndex = 4;
            this.tstOperaciones.Text = "toolStrip1";
            // 
            // tstbuttonSuma
            // 
            this.tstbuttonSuma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbuttonSuma.Image = ((System.Drawing.Image)(resources.GetObject("tstbuttonSuma.Image")));
            this.tstbuttonSuma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbuttonSuma.Name = "tstbuttonSuma";
            this.tstbuttonSuma.Size = new System.Drawing.Size(23, 22);
            this.tstbuttonSuma.Text = "Sumar";
            this.tstbuttonSuma.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // tstbuttonResta
            // 
            this.tstbuttonResta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbuttonResta.Image = ((System.Drawing.Image)(resources.GetObject("tstbuttonResta.Image")));
            this.tstbuttonResta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbuttonResta.Name = "tstbuttonResta";
            this.tstbuttonResta.Size = new System.Drawing.Size(23, 22);
            this.tstbuttonResta.Text = "Restar";
            this.tstbuttonResta.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // tstbuttonMulti
            // 
            this.tstbuttonMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbuttonMulti.Image = ((System.Drawing.Image)(resources.GetObject("tstbuttonMulti.Image")));
            this.tstbuttonMulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbuttonMulti.Name = "tstbuttonMulti";
            this.tstbuttonMulti.Size = new System.Drawing.Size(23, 22);
            this.tstbuttonMulti.Text = "Multiplicar";
            this.tstbuttonMulti.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // tstbuttonDiv
            // 
            this.tstbuttonDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbuttonDiv.Image = ((System.Drawing.Image)(resources.GetObject("tstbuttonDiv.Image")));
            this.tstbuttonDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbuttonDiv.Name = "tstbuttonDiv";
            this.tstbuttonDiv.Size = new System.Drawing.Size(23, 22);
            this.tstbuttonDiv.Text = "Dividir";
            this.tstbuttonDiv.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // stsInformacion
            // 
            this.stsInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblValores,
            this.slblOperacion,
            this.slblResultado});
            this.stsInformacion.Location = new System.Drawing.Point(0, 227);
            this.stsInformacion.Name = "stsInformacion";
            this.stsInformacion.Size = new System.Drawing.Size(354, 24);
            this.stsInformacion.TabIndex = 5;
            this.stsInformacion.Text = "statusStrip1";
            // 
            // slblValores
            // 
            this.slblValores.AutoSize = false;
            this.slblValores.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblValores.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.slblValores.Name = "slblValores";
            this.slblValores.Size = new System.Drawing.Size(60, 19);
            this.slblValores.Text = "A=0, B=0";
            // 
            // slblOperacion
            // 
            this.slblOperacion.AutoSize = false;
            this.slblOperacion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblOperacion.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.slblOperacion.Name = "slblOperacion";
            this.slblOperacion.Size = new System.Drawing.Size(89, 19);
            this.slblOperacion.Text = "Sin seleccionar";
            // 
            // slblResultado
            // 
            this.slblResultado.AutoSize = false;
            this.slblResultado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblResultado.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.slblResultado.Name = "slblResultado";
            this.slblResultado.Size = new System.Drawing.Size(32, 19);
            this.slblResultado.Text = "R=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 251);
            this.Controls.Add(this.stsInformacion);
            this.Controls.Add(this.tstOperaciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmenuTxtA.ResumeLayout(false);
            this.tstOperaciones.ResumeLayout(false);
            this.tstOperaciones.PerformLayout();
            this.stsInformacion.ResumeLayout(false);
            this.stsInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmenuTxtA;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tstOperaciones;
        private System.Windows.Forms.ToolStripButton tstbuttonSuma;
        private System.Windows.Forms.ToolStripButton tstbuttonResta;
        private System.Windows.Forms.ToolStripButton tstbuttonMulti;
        private System.Windows.Forms.ToolStripButton tstbuttonDiv;
        private System.Windows.Forms.StatusStrip stsInformacion;
        private System.Windows.Forms.ToolStripStatusLabel slblValores;
        private System.Windows.Forms.ToolStripStatusLabel slblOperacion;
        private System.Windows.Forms.ToolStripStatusLabel slblResultado;
    }
}

