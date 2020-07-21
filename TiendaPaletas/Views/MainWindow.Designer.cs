namespace TiendaPaletas.Views
{
    partial class MainWindow
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
            this.btnRegistrarCat = new System.Windows.Forms.Button();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.txtNuevaCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNuevoNombreCat = new System.Windows.Forms.TextBox();
            this.btnEditarCat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNuevoNombreProducto = new System.Windows.Forms.TextBox();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.txtNuevoStock = new System.Windows.Forms.TextBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarCat
            // 
            this.btnRegistrarCat.Location = new System.Drawing.Point(116, 57);
            this.btnRegistrarCat.Name = "btnRegistrarCat";
            this.btnRegistrarCat.Size = new System.Drawing.Size(133, 23);
            this.btnRegistrarCat.TabIndex = 0;
            this.btnRegistrarCat.Text = "Nueva Categoria";
            this.btnRegistrarCat.UseVisualStyleBackColor = true;
            this.btnRegistrarCat.Click += new System.EventHandler(this.btnRegistrarCat_Click);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(351, 35);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(136, 21);
            this.cmbCategorias.TabIndex = 1;
            this.cmbCategorias.TextChanged += new System.EventHandler(this.cmbCategorias_TextChanged);
            // 
            // txtNuevaCat
            // 
            this.txtNuevaCat.Location = new System.Drawing.Point(116, 31);
            this.txtNuevaCat.Name = "txtNuevaCat";
            this.txtNuevaCat.Size = new System.Drawing.Size(133, 20);
            this.txtNuevaCat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtNuevoProducto
            // 
            this.txtNuevoProducto.Location = new System.Drawing.Point(116, 263);
            this.txtNuevoProducto.Name = "txtNuevoProducto";
            this.txtNuevoProducto.Size = new System.Drawing.Size(133, 23);
            this.txtNuevoProducto.TabIndex = 4;
            this.txtNuevoProducto.Text = "Nuevo Producto";
            this.txtNuevoProducto.UseVisualStyleBackColor = true;
            this.txtNuevoProducto.Click += new System.EventHandler(this.txtNuevoProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(116, 181);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(133, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(116, 213);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(133, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(116, 239);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(133, 20);
            this.txtStock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nuevo nombre Cat";
            // 
            // txtNuevoNombreCat
            // 
            this.txtNuevoNombreCat.Location = new System.Drawing.Point(116, 86);
            this.txtNuevoNombreCat.Name = "txtNuevoNombreCat";
            this.txtNuevoNombreCat.Size = new System.Drawing.Size(136, 20);
            this.txtNuevoNombreCat.TabIndex = 13;
            // 
            // btnEditarCat
            // 
            this.btnEditarCat.Location = new System.Drawing.Point(116, 113);
            this.btnEditarCat.Name = "btnEditarCat";
            this.btnEditarCat.Size = new System.Drawing.Size(133, 23);
            this.btnEditarCat.TabIndex = 14;
            this.btnEditarCat.Text = "Editar Nombre Cat";
            this.btnEditarCat.UseVisualStyleBackColor = true;
            this.btnEditarCat.Click += new System.EventHandler(this.btnEditarCat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nuevo nombre prod";
            // 
            // txtNuevoNombreProducto
            // 
            this.txtNuevoNombreProducto.Location = new System.Drawing.Point(395, 173);
            this.txtNuevoNombreProducto.Name = "txtNuevoNombreProducto";
            this.txtNuevoNombreProducto.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoNombreProducto.TabIndex = 16;
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(395, 199);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoPrecio.TabIndex = 17;
            // 
            // txtNuevoStock
            // 
            this.txtNuevoStock.Location = new System.Drawing.Point(395, 226);
            this.txtNuevoStock.Name = "txtNuevoStock";
            this.txtNuevoStock.Size = new System.Drawing.Size(130, 20);
            this.txtNuevoStock.TabIndex = 18;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(351, 89);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(136, 21);
            this.cmbProductos.TabIndex = 19;
            this.cmbProductos.TextChanged += new System.EventHandler(this.cmbProductos_TextChanged);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Location = new System.Drawing.Point(395, 254);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(130, 23);
            this.btnActualizarProducto.TabIndex = 20;
            this.btnActualizarProducto.Text = "Actualizar Producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 289);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.txtNuevoStock);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.txtNuevoNombreProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEditarCat);
            this.Controls.Add(this.txtNuevoNombreCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtNuevoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevaCat);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.btnRegistrarCat);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCat;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.TextBox txtNuevaCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtNuevoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuevoNombreCat;
        private System.Windows.Forms.Button btnEditarCat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNuevoNombreProducto;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevoStock;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Button btnActualizarProducto;
    }
}