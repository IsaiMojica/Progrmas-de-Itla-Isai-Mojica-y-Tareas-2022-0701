namespace Programa_4._8
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
            this.btnAdicionaN = new System.Windows.Forms.Button();
            this.btnAdicionaE = new System.Windows.Forms.Button();
            this.btnLimpia = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnAdicionaN
            // 
            this.btnAdicionaN.Location = new System.Drawing.Point(309, 13);
            this.btnAdicionaN.Name = "btnAdicionaN";
            this.btnAdicionaN.Size = new System.Drawing.Size(116, 23);
            this.btnAdicionaN.TabIndex = 0;
            this.btnAdicionaN.Text = "Adiciona Nodo";
            this.btnAdicionaN.UseVisualStyleBackColor = true;
            this.btnAdicionaN.Click += new System.EventHandler(this.btnAdicionaN_Click);
            // 
            // btnAdicionaE
            // 
            this.btnAdicionaE.Location = new System.Drawing.Point(309, 42);
            this.btnAdicionaE.Name = "btnAdicionaE";
            this.btnAdicionaE.Size = new System.Drawing.Size(116, 23);
            this.btnAdicionaE.TabIndex = 1;
            this.btnAdicionaE.Text = "Adiciona Elemento";
            this.btnAdicionaE.UseVisualStyleBackColor = true;
            this.btnAdicionaE.Click += new System.EventHandler(this.btnAdicionaE_Click);
            // 
            // btnLimpia
            // 
            this.btnLimpia.Location = new System.Drawing.Point(309, 71);
            this.btnLimpia.Name = "btnLimpia";
            this.btnLimpia.Size = new System.Drawing.Size(116, 23);
            this.btnLimpia.TabIndex = 2;
            this.btnLimpia.Text = "Limpia Arbol";
            this.btnLimpia.UseVisualStyleBackColor = true;
            this.btnLimpia.Click += new System.EventHandler(this.btnLimpia_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(309, 100);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(116, 23);
            this.btnElimina.TabIndex = 3;
            this.btnElimina.Text = "Elimina Nodo";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(203, 13);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 4;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(203, 39);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(184, 273);
            this.treeView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 298);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnLimpia);
            this.Controls.Add(this.btnAdicionaE);
            this.Controls.Add(this.btnAdicionaN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionaN;
        private System.Windows.Forms.Button btnAdicionaE;
        private System.Windows.Forms.Button btnLimpia;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.TreeView treeView1;
    }
}

