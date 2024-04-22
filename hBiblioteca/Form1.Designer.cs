namespace hBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLibrosFisicos = new System.Windows.Forms.Button();
            this.btnLibrosElectronicos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLibrosFisicos
            // 
            this.btnLibrosFisicos.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrosFisicos.Image = ((System.Drawing.Image)(resources.GetObject("btnLibrosFisicos.Image")));
            this.btnLibrosFisicos.Location = new System.Drawing.Point(28, 188);
            this.btnLibrosFisicos.Name = "btnLibrosFisicos";
            this.btnLibrosFisicos.Size = new System.Drawing.Size(387, 384);
            this.btnLibrosFisicos.TabIndex = 0;
            this.btnLibrosFisicos.Text = "Libros Físicos";
            this.btnLibrosFisicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibrosFisicos.UseVisualStyleBackColor = true;
            this.btnLibrosFisicos.Click += new System.EventHandler(this.btnLibrosFisicos_Click);
            // 
            // btnLibrosElectronicos
            // 
            this.btnLibrosElectronicos.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrosElectronicos.Image = ((System.Drawing.Image)(resources.GetObject("btnLibrosElectronicos.Image")));
            this.btnLibrosElectronicos.Location = new System.Drawing.Point(480, 188);
            this.btnLibrosElectronicos.Name = "btnLibrosElectronicos";
            this.btnLibrosElectronicos.Size = new System.Drawing.Size(376, 380);
            this.btnLibrosElectronicos.TabIndex = 1;
            this.btnLibrosElectronicos.Text = "Libros Electrónicos";
            this.btnLibrosElectronicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibrosElectronicos.UseVisualStyleBackColor = true;
            this.btnLibrosElectronicos.Click += new System.EventHandler(this.btnLibrosElectronicos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestión De Bibliotecas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLibrosElectronicos);
            this.Controls.Add(this.btnLibrosFisicos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLibrosFisicos;
        private System.Windows.Forms.Button btnLibrosElectronicos;
        private System.Windows.Forms.Label label1;
    }
}

