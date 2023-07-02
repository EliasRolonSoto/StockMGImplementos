namespace StockMenu
{
    partial class Agregar
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            cbTipo = new ComboBox();
            btnAgregar = new Button();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblTipo = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(141, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(122, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 1;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Materia Prima", "Producto en Proceso", "Producto Terminado" });
            cbTipo.Location = new Point(141, 197);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(141, 255);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 48);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(141, 135);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(141, 153);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(188, 23);
            txtCantidad.TabIndex = 5;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(141, 179);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(98, 15);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo de producto";
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 464);
            Controls.Add(lblTipo);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(cbTipo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Agregar";
            Text = "Agregar";
            Load += Agregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private ComboBox cbTipo;
        private Button btnAgregar;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblTipo;
    }
}