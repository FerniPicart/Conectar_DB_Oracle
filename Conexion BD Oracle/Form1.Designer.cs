namespace Conexion_BD_Oracle
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
            this.lbl_estado = new System.Windows.Forms.Label();
            this.btn_ConectarBD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_estado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(30, 30);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(194, 34);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Sin Conexión.";
            // 
            // btn_ConectarBD
            // 
            this.btn_ConectarBD.FlatAppearance.BorderSize = 4;
            this.btn_ConectarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConectarBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConectarBD.Location = new System.Drawing.Point(758, 30);
            this.btn_ConectarBD.Name = "btn_ConectarBD";
            this.btn_ConectarBD.Size = new System.Drawing.Size(194, 82);
            this.btn_ConectarBD.TabIndex = 1;
            this.btn_ConectarBD.Text = "Conectar a BD";
            this.btn_ConectarBD.UseVisualStyleBackColor = true;
            this.btn_ConectarBD.Click += new System.EventHandler(this.btn_ConectarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(10)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btn_ConectarBD);
            this.Controls.Add(this.lbl_estado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion a BD de Netsuite Oracle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_ConectarBD;
    }
}

