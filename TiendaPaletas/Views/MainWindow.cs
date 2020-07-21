using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TiendaPaletas.Views
{
    public partial class MainWindow : Form
    {
        Controllers.CategoriaController categoriaController = new Controllers.CategoriaController();
        Controllers.ProductoController productoController = new Controllers.ProductoController();

        Helpers.getCategoryId catid = new Helpers.getCategoryId();
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        public void FillComboBox()
        {
            DataTable dt = new DataTable();
            dt = categoriaController.getAllCategories();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                cmbCategorias.Items.Add(dt.Rows[i]["nombre"]);
            }
        }

        private void btnRegistrarCat_Click(object sender, EventArgs e)
        {
            string nombreCat = txtNuevaCat.Text;
            string message = categoriaController.create(nombreCat);
            if(message == "Success")
            {
                cmbCategorias.Items.Clear();
                FillComboBox();
                MessageBox.Show("Categoria Creada Con exito");
            }
            else
            {
                MessageBox.Show("Error al crear categoria");
            }
        }

        private void txtNuevoProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text;
            float precio = float.Parse(txtPrecio.Text);
            
            int stock = Int32.Parse(txtStock.Text);
            int categoria_id = catid.getId(cmbCategorias.Text);
            string message = productoController.create(nombre, categoria_id, precio, stock);
            if(message == "SUCCESS")
            {
                MessageBox.Show("Creado Correctamente");
                DataTable dt = productoController.getProductos(cmbCategorias.Text);
                fillProductos(dt);
            }
            else
            {
                MessageBox.Show("Error al crear producto");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarCat_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNuevoNombreCat.Text;
            string viejoNombre = cmbCategorias.Text;
            string message = categoriaController.edit(nuevoNombre,viejoNombre);
            if(message == "SUCCESS")
            {
                MessageBox.Show("Categoria editada Correctamente");
                cmbCategorias.Items.Clear();
                FillComboBox();
            }
            else
            {
                MessageBox.Show("Error al editar la categoria");
            }
        }

        private void cmbCategorias_TextChanged(object sender, EventArgs e)
        {
            //AQUI ME QUEDE ACTUALIZAR EL CMB DE COMBO DE PRODUCTOS AL CAMBIAR NOMBRE DE CMB DE CATEGORIAS
            DataTable dt = productoController.getProductos(cmbCategorias.Text);
            fillProductos(dt);
            
        }

        public void fillProductos(DataTable dt)
        {
            cmbProductos.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbProductos.Items.Add(dt.Rows[i]["nombre"]);
            }
        }

        private void cmbProductos_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = productoController.getProductosTotales(cmbProductos.Text);
            try
            {
                txtNuevoNombreProducto.Text = dt.Rows[0]["nombre"].ToString();
                txtNuevoPrecio.Text = dt.Rows[0]["precio"].ToString();
                txtNuevoStock.Text = dt.Rows[0]["stock"].ToString();
            }
            catch
            {

            }

            
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            Helpers.getProductoId getId = new Helpers.getProductoId();
            int id = getId.getId(cmbProductos.Text);
            string nombre = txtNuevoNombreProducto.Text;
            float precio = float.Parse(txtNuevoPrecio.Text);
            int stock = int.Parse(txtNuevoStock.Text);
            string message = productoController.edit(id, nombre, precio, stock);
            if(message == "SUCCESS")
            {
                MessageBox.Show("Item editado Correctamente");

            }
            else
            {
                MessageBox.Show("Error al editar");
            }
        }
    }
}
