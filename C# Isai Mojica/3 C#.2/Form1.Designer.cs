namespace Programa_3._2
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
            this.imgLFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnCambio = new System.Windows.Forms.Button();
            this.picBImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLFotos
            // 
            this.imgLFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLFotos.ImageStream")));
            this.imgLFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLFotos.Images.SetKeyName(0, "14-148130_minion-imagenes-de-100x100-pixeles.png");
            this.imgLFotos.Images.SetKeyName(1, "images.jpg");
            this.imgLFotos.Images.SetKeyName(2, "pacman-png-23.png");
            this.imgLFotos.Images.SetKeyName(3, "unnamed.jpg");
            this.imgLFotos.Images.SetKeyName(4, "Bitmap1.bmp");
            // 
            // lblFoto
            // 
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.imgLFotos;
            this.lblFoto.Location = new System.Drawing.Point(13, 13);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(100, 100);
            this.lblFoto.TabIndex = 0;
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(34, 142);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(122, 23);
            this.btnCambio.TabIndex = 1;
            this.btnCambio.Text = "Cambiar Imagen";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // picBImagen
            // 
            this.picBImagen.Location = new System.Drawing.Point(154, 13);
            this.picBImagen.Name = "picBImagen";
            this.picBImagen.Size = new System.Drawing.Size(100, 100);
            this.picBImagen.TabIndex = 2;
            this.picBImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 273);
            this.Controls.Add(this.picBImagen);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.lblFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgLFotos;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.PictureBox picBImagen;
    }
}

