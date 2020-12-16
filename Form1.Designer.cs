namespace POOpractica0._01_clase_
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
            this.btn_Llamar = new System.Windows.Forms.Button();
            this.btn_ContestarLlamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Llamar
            // 
            this.btn_Llamar.Location = new System.Drawing.Point(226, 144);
            this.btn_Llamar.Name = "btn_Llamar";
            this.btn_Llamar.Size = new System.Drawing.Size(302, 135);
            this.btn_Llamar.TabIndex = 0;
            this.btn_Llamar.Text = "Llamar";
            this.btn_Llamar.UseVisualStyleBackColor = true;
            this.btn_Llamar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ContestarLlamada
            // 
            this.btn_ContestarLlamada.Location = new System.Drawing.Point(226, 329);
            this.btn_ContestarLlamada.Name = "btn_ContestarLlamada";
            this.btn_ContestarLlamada.Size = new System.Drawing.Size(302, 162);
            this.btn_ContestarLlamada.TabIndex = 1;
            this.btn_ContestarLlamada.Text = "ContestarLlamada";
            this.btn_ContestarLlamada.UseVisualStyleBackColor = true;
            this.btn_ContestarLlamada.Click += new System.EventHandler(this.btn_ContestarLlamada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.btn_ContestarLlamada);
            this.Controls.Add(this.btn_Llamar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Llamar;
        private System.Windows.Forms.Button btn_ContestarLlamada;
    }
}

