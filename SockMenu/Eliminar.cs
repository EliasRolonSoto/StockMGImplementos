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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != string.Empty && txtNombre.Text != string.Empty && cbTipo.SelectedItem != string.Empty)
            {
                var eliminar = new StockBusiness();
                var producto = new Producto()
                {
                    NombreProducto = txtNombre.Text,
                    TipoProducto = cbTipo.SelectedItem.ToString(),
                    Cantidad = int.Parse(txtCantidad.Text)
                };
                eliminar.Eliminar(producto);
                MessageBox.Show("Producto eliminado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Completa todos los campos!", "!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
