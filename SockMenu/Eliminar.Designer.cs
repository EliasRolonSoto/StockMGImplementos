namespace StockMenu
{
    partial class Eliminar
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
            lblTipo = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            btnEliminar = new Button();
            cbTipo = new ComboBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(113, 206);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(98, 15);
            lblTipo.TabIndex = 13;
            lblTipo.Text = "Tipo de producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(113, 180);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(188, 23);
            txtCantidad.TabIndex = 12;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(113, 162);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 11;
            lblCantidad.Text = "Cantidad";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(113, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 48);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Materia Prima", "Producto en Proceso", "Producto Terminado" });
            cbTipo.Location = new Point(113, 224);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(113, 118);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(122, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre del Producto";
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 448);
            Controls.Add(lblTipo);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnEliminar);
            Controls.Add(cbTipo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Eliminar";
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnEliminar;
        private ComboBox cbTipo;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}