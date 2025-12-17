namespace AGP
{
    partial class FormLixo
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
            btnOk = new Button();
            txtAdd = new TextBox();
            dgv = new DataGridView();
            txtEndereco = new TextBox();
            btnEditar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(30, 27);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(85, 66);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(121, 28);
            txtAdd.Name = "txtAdd";
            txtAdd.PlaceholderText = "Nome";
            txtAdd.Size = new Size(163, 23);
            txtAdd.TabIndex = 1;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(331, 27);
            dgv.Name = "dgv";
            dgv.Size = new Size(483, 397);
            dgv.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(121, 70);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço";
            txtEndereco.Size = new Size(163, 23);
            txtEndereco.TabIndex = 3;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(27, 353);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(28, 389);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // FormLixo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 454);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(txtEndereco);
            Controls.Add(dgv);
            Controls.Add(txtAdd);
            Controls.Add(btnOk);
            Name = "FormLixo";
            Text = "FormLixo";
            Load += FormLixo_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private TextBox txtAdd;
        private DataGridView dgv;
        private TextBox txtEndereco;
        private Button btnEditar;
        private Button btnRemover;
    }
}