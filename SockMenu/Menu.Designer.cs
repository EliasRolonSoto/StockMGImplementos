namespace SockMenu
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            lblMenu = new Label();
            btnEliminar = new Button();
            btnVerStock = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(171, 133);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(158, 66);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(188, 65);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(130, 30);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menu Stock";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(171, 205);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 66);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVerStock
            // 
            btnVerStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerStock.Location = new Point(171, 277);
            btnVerStock.Name = "btnVerStock";
            btnVerStock.Size = new Size(158, 66);
            btnVerStock.TabIndex = 3;
            btnVerStock.Text = "Ver Stock";
            btnVerStock.UseVisualStyleBackColor = true;
            btnVerStock.Click += btnVerStock_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 490);
            Controls.Add(btnVerStock);
            Controls.Add(btnEliminar);
            Controls.Add(lblMenu);
            Controls.Add(btnAgregar);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblMenu;
        private Button btnEliminar;
        private Button btnVerStock;
    }
}