namespace StockMenu
{
    partial class VerStock
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
            dgvStock = new DataGridView();
            txtBusqueda = new TextBox();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(12, 117);
            dgvStock.Name = "dgvStock";
            dgvStock.RowTemplate.Height = 25;
            dgvStock.Size = new Size(561, 361);
            dgvStock.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(12, 88);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(313, 23);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(12, 61);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(94, 15);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar Producto";
            // 
            // VerStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 490);
            Controls.Add(lblBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(dgvStock);
            Name = "VerStock";
            Text = "VerStock";
            Load += VerStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStock;
        private TextBox txtBusqueda;
        private Label lblBuscar;
    }
}