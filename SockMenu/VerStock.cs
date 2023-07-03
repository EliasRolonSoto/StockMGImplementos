using AccesoADatosConRepoDb.Business;
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
    public partial class VerStock : Form
    {
        private StockBusiness _productos;
        public VerStock()
        {
            InitializeComponent();
            _productos = new StockBusiness();
        }

        private void VerStock_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var datos = _productos.Busqueda(txtBusqueda.Text);
            dgvStock.DataSource = datos;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
