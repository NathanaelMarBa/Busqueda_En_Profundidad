namespace Busqueda_En_Profundidad
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
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.txtNumeroaBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Location = new System.Drawing.Point(247, 180);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(169, 75);
            this.btnProfundidad.TabIndex = 0;
            this.btnProfundidad.Text = "Busqueda en Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // txtNumeroaBuscar
            // 
            this.txtNumeroaBuscar.Location = new System.Drawing.Point(265, 121);
            this.txtNumeroaBuscar.Name = "txtNumeroaBuscar";
            this.txtNumeroaBuscar.Size = new System.Drawing.Size(128, 26);
            this.txtNumeroaBuscar.TabIndex = 1;
            this.txtNumeroaBuscar.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroaBuscar);
            this.Controls.Add(this.btnProfundidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.TextBox txtNumeroaBuscar;
    }
}

