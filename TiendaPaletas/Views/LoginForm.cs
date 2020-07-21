using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaPaletas
{
    public partial class Form1 : Form
    {
        Controllers.UserController userC = new Controllers.UserController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try { 
                DataTable dt = new DataTable();
                int numeroE = int.Parse(txtNumeroEmpleado.Text);
                string nombreE = txtNombreEmpleado.Text;

                dt = userC.getUser(numeroE,nombreE);
                if(dt.Rows.Count>0)
                {
                    txtResultado.Text = "Login Correcto";
                    Views.MainWindow main = new Views.MainWindow();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    txtResultado.Text = "Error, Usuario y/o Contraseña incorrecta";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
