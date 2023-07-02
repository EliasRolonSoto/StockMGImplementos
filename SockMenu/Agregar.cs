using AccesoADatosConRepoDb.Business;
using AccesoADatosConRepoDb.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMenu
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != null && txtNombre.Text != null && cbTipo.SelectedIndex != null)
            {
                var agregar = new RepoDbBusiness();
                var producto = new Producto()
                {
                    NombreProducto = txtNombre.Text,
                    TipoProducto = cbTipo.SelectedItem.ToString(),
                    Cantidad = int.Parse(txtCantidad.Text)
                };
                agregar.Agregar(producto);
                MessageBox.Show("Producto agregado al stock");
                this.Close();
            }
            else
            {
                MessageBox.Show("Completa todos los campos!", "!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
