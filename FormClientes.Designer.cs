namespace AGP
{
    partial class FormClientes
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
            btnOkClientes = new Button();
            btnEditarCliente = new Button();
            btnRemoverCliente = new Button();
            txtNomeCliente = new TextBox();
            dgvClientes = new DataGridView();
            txtRefCliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnOkClientes
            // 
            btnOkClientes.Location = new Point(47, 38);
            btnOkClientes.Name = "btnOkClientes";
            btnOkClientes.Size = new Size(75, 57);
            btnOkClientes.TabIndex = 0;
            btnOkClientes.Text = "OK";
            btnOkClientes.UseVisualStyleBackColor = true;
            btnOkClientes.Click += btnOkClientes_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(47, 333);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(75, 23);
            btnEditarCliente.TabIndex = 1;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnRemoverCliente
            // 
            btnRemoverCliente.Location = new Point(47, 382);
            btnRemoverCliente.Name = "btnRemoverCliente";
            btnRemoverCliente.Size = new Size(75, 23);
            btnRemoverCliente.TabIndex = 2;
            btnRemoverCliente.Text = "Remover";
            btnRemoverCliente.UseVisualStyleBackColor = true;
            btnRemoverCliente.Click += btnRemoverCliente_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(143, 43);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(130, 23);
            txtNomeCliente.TabIndex = 3;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(301, 38);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(463, 367);
            dgvClientes.TabIndex = 4;
            // 
            // txtRefCliente
            // 
            txtRefCliente.Location = new Point(143, 72);
            txtRefCliente.Name = "txtRefCliente";
            txtRefCliente.Size = new Size(130, 23);
            txtRefCliente.TabIndex = 5;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRefCliente);
            Controls.Add(dgvClientes);
            Controls.Add(txtNomeCliente);
            Controls.Add(btnRemoverCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(btnOkClientes);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOkClientes;
        private Button btnEditarCliente;
        private Button btnRemoverCliente;
        private TextBox txtNomeCliente;
        private DataGridView dgvClientes;
        private TextBox txtRefCliente;
    }
}