namespace TiendaPaletas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(243, 95);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(111, 95);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(111, 161);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.PasswordChar = '*';
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEmpleado.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(111, 224);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(262, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 277);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

