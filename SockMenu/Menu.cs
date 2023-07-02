using StockMenu;

namespace SockMenu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new Agregar();
            form.ShowDialog();
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            var form = new VerStock();
            form.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var form = new Eliminar();
            form.ShowDialog();
        }
    }
}