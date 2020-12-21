
namespace Prueba1
{
    partial class frmBuscarFichero
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
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBuscarFichero = new System.Windows.Forms.Button();
            this.fbBuscarFichero = new System.Windows.Forms.FolderBrowserDialog();
            this.fdBuscarFichero = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(12, 118);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(1065, 26);
            this.tbFilePath.TabIndex = 0;
            // 
            // btnBuscarFichero
            // 
            this.btnBuscarFichero.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarFichero.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarFichero.Name = "btnBuscarFichero";
            this.btnBuscarFichero.Size = new System.Drawing.Size(1089, 71);
            this.btnBuscarFichero.TabIndex = 1;
            this.btnBuscarFichero.Text = "Buscar Fichero";
            this.btnBuscarFichero.UseVisualStyleBackColor = true;
            this.btnBuscarFichero.Click += new System.EventHandler(this.btnBuscarFichero_Click);
            // 
            // fdBuscarFichero
            // 
            this.fdBuscarFichero.FileName = "openFileDialog1";
            this.fdBuscarFichero.FileOk += new System.ComponentModel.CancelEventHandler(this.fdBuscarFichero_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1065, 26);
            this.textBox1.TabIndex = 2;
            // 
            // frmBuscarFichero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 210);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscarFichero);
            this.Controls.Add(this.tbFilePath);
            this.Name = "frmBuscarFichero";
            this.Text = "Mostrar Path Fichero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBuscarFichero;
        private System.Windows.Forms.FolderBrowserDialog fbBuscarFichero;
        private System.Windows.Forms.OpenFileDialog fdBuscarFichero;
        private System.Windows.Forms.TextBox textBox1;
    }
}

