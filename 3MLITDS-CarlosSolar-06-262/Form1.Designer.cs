namespace _3MLITDS_CarlosSolar_06_262
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
            this.btnencender = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnencender
            // 
            this.btnencender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnencender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencender.Location = new System.Drawing.Point(4, 12);
            this.btnencender.Name = "btnencender";
            this.btnencender.Size = new System.Drawing.Size(784, 192);
            this.btnencender.TabIndex = 0;
            this.btnencender.Text = "encender";
            this.btnencender.UseVisualStyleBackColor = false;
            this.btnencender.Click += new System.EventHandler(this.btnencender_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapagar.Location = new System.Drawing.Point(4, 249);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(784, 189);
            this.btnapagar.TabIndex = 1;
            this.btnapagar.Text = "apagar";
            this.btnapagar.UseVisualStyleBackColor = false;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btnencender);
            this.Name = "Form1";
            this.Text = "actividad 07 encender led";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnencender;
        private System.Windows.Forms.Button btnapagar;
    }
}

