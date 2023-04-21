namespace Programa_3._3
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
            this.lsvAlimentos = new System.Windows.Forms.ListView();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.rbtCarnes = new System.Windows.Forms.RadioButton();
            this.rbtFrutas = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblSeleciondo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvAlimentos
            // 
            this.lsvAlimentos.HideSelection = false;
            this.lsvAlimentos.Location = new System.Drawing.Point(13, 24);
            this.lsvAlimentos.Name = "lsvAlimentos";
            this.lsvAlimentos.Size = new System.Drawing.Size(273, 147);
            this.lsvAlimentos.TabIndex = 0;
            this.lsvAlimentos.UseCompatibleStateImageBehavior = false;
            this.lsvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.lsvAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvAlimentos_MouseClick);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(13, 189);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // gbGrupos
            // 
            this.gbGrupos.Controls.Add(this.rbtCarnes);
            this.gbGrupos.Controls.Add(this.rbtFrutas);
            this.gbGrupos.Location = new System.Drawing.Point(119, 189);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(200, 100);
            this.gbGrupos.TabIndex = 2;
            this.gbGrupos.TabStop = false;
            this.gbGrupos.Text = "groupBox1";
            // 
            // rbtCarnes
            // 
            this.rbtCarnes.AutoSize = true;
            this.rbtCarnes.Location = new System.Drawing.Point(7, 43);
            this.rbtCarnes.Name = "rbtCarnes";
            this.rbtCarnes.Size = new System.Drawing.Size(58, 17);
            this.rbtCarnes.TabIndex = 1;
            this.rbtCarnes.Text = "Carnes";
            this.rbtCarnes.UseVisualStyleBackColor = true;
            // 
            // rbtFrutas
            // 
            this.rbtFrutas.AutoSize = true;
            this.rbtFrutas.Checked = true;
            this.rbtFrutas.Location = new System.Drawing.Point(7, 20);
            this.rbtFrutas.Name = "rbtFrutas";
            this.rbtFrutas.Size = new System.Drawing.Size(54, 17);
            this.rbtFrutas.TabIndex = 0;
            this.rbtFrutas.TabStop = true;
            this.rbtFrutas.Text = "Frutas";
            this.rbtFrutas.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(125, 296);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblSeleciondo
            // 
            this.lblSeleciondo.AutoSize = true;
            this.lblSeleciondo.Location = new System.Drawing.Point(292, 24);
            this.lblSeleciondo.Name = "lblSeleciondo";
            this.lblSeleciondo.Size = new System.Drawing.Size(35, 13);
            this.lblSeleciondo.TabIndex = 4;
            this.lblSeleciondo.Text = "label1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(292, 49);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(292, 79);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(13, 216);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 7;
            this.txtImagen.Text = "0";
            this.txtImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(13, 243);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 351);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblSeleciondo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.gbGrupos);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lsvAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGrupos.ResumeLayout(false);
            this.gbGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvAlimentos;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.RadioButton rbtCarnes;
        private System.Windows.Forms.RadioButton rbtFrutas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblSeleciondo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnActualizar;
    }
}

