namespace AGP.Forms
{
    partial class MainForm :Form
    {
        private System.ComponentModel.IContainer components = null;
        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            processosToolStripMenuItem = new ToolStripMenuItem();
            estadosToolStripMenuItem = new ToolStripMenuItem();
            btnProcesso = new Button();
            btnLP = new Button();
            dgvProcesso = new DataGridView();
            dgvLP = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnRemover = new Button();
            cmbCategoria = new ComboBox();
            cmbEstado = new ComboBox();
            cmbPrioridade = new ComboBox();
            cmbFuncionario = new ComboBox();
            cmbCliente = new ComboBox();
            lblCategoria = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rdbSimples = new RadioButton();
            rdbCompleto = new RadioButton();
            label7 = new Label();
            lstCategoria = new ListBox();
            lstEstado = new ListBox();
            lstPrioridade = new ListBox();
            btnRemoverLP = new Button();
            btnLimpar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcesso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLP).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, funcionáriosToolStripMenuItem, categoriasToolStripMenuItem, processosToolStripMenuItem, estadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1361, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new Size(87, 20);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += funcionáriosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // processosToolStripMenuItem
            // 
            processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            processosToolStripMenuItem.Size = new Size(71, 20);
            processosToolStripMenuItem.Text = "Processos";
            // 
            // estadosToolStripMenuItem
            // 
            estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            estadosToolStripMenuItem.Size = new Size(59, 20);
            estadosToolStripMenuItem.Text = "Estados";
            estadosToolStripMenuItem.Click += estadosToolStripMenuItem_Click;
            // 
            // btnProcesso
            // 
            btnProcesso.Location = new Point(25, 686);
            btnProcesso.Name = "btnProcesso";
            btnProcesso.Size = new Size(84, 23);
            btnProcesso.TabIndex = 6;
            btnProcesso.Text = "Processos";
            btnProcesso.UseVisualStyleBackColor = true;
            btnProcesso.Click += btnProcesso_Click;
            // 
            // btnLP
            // 
            btnLP.Location = new Point(115, 686);
            btnLP.Name = "btnLP";
            btnLP.Size = new Size(126, 23);
            btnLP.TabIndex = 7;
            btnLP.Text = "Linha de Processo";
            btnLP.UseVisualStyleBackColor = true;
            btnLP.Click += btnLP_Click;
            // 
            // dgvProcesso
            // 
            dgvProcesso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProcesso.Location = new Point(25, 79);
            dgvProcesso.Name = "dgvProcesso";
            dgvProcesso.Size = new Size(1089, 332);
            dgvProcesso.TabIndex = 8;
            // 
            // dgvLP
            // 
            dgvLP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLP.Location = new Point(25, 444);
            dgvLP.Name = "dgvLP";
            dgvLP.Size = new Size(1089, 236);
            dgvLP.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1002, 426);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 10;
            label1.Text = "Linhas de Processos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1055, 61);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 11;
            label2.Text = "Processos";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(902, 686);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(118, 23);
            btnRemover.TabIndex = 12;
            btnRemover.Text = "Remover processo";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click_1;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(95, 52);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 13;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(287, 52);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 14;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(495, 52);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(121, 23);
            cmbPrioridade.TabIndex = 15;
            cmbPrioridade.SelectedIndexChanged += cmbPrioridade_SelectedIndexChanged;
            // 
            // cmbFuncionario
            // 
            cmbFuncionario.FormattingEnabled = true;
            cmbFuncionario.Location = new Point(718, 52);
            cmbFuncionario.Name = "cmbFuncionario";
            cmbFuncionario.Size = new Size(121, 23);
            cmbFuncionario.TabIndex = 16;
            cmbFuncionario.SelectedIndexChanged += cmbFuncionario_SelectedIndexChanged;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(909, 52);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 17;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(26, 57);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(63, 15);
            lblCategoria.TabIndex = 18;
            lblCategoria.Text = "Categorias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(234, 57);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 19;
            label3.Text = "Estados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 57);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 20;
            label4.Text = "Prioridades";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(637, 57);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 21;
            label5.Text = "Funcionários";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(854, 57);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 22;
            label6.Text = "Clientes";
            // 
            // rdbSimples
            // 
            rdbSimples.AutoSize = true;
            rdbSimples.Location = new Point(184, 419);
            rdbSimples.Name = "rdbSimples";
            rdbSimples.Size = new Size(66, 19);
            rdbSimples.TabIndex = 23;
            rdbSimples.TabStop = true;
            rdbSimples.Text = "Simples";
            rdbSimples.UseVisualStyleBackColor = true;
            // 
            // rdbCompleto
            // 
            rdbCompleto.AutoSize = true;
            rdbCompleto.Location = new Point(287, 419);
            rdbCompleto.Name = "rdbCompleto";
            rdbCompleto.Size = new Size(78, 19);
            rdbCompleto.TabIndex = 24;
            rdbCompleto.TabStop = true;
            rdbCompleto.Text = "Completo";
            rdbCompleto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 421);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 25;
            label7.Text = "Visualização da grid";
            // 
            // lstCategoria
            // 
            lstCategoria.AccessibleName = "";
            lstCategoria.FormattingEnabled = true;
            lstCategoria.Location = new Point(1120, 79);
            lstCategoria.Name = "lstCategoria";
            lstCategoria.Size = new Size(210, 199);
            lstCategoria.TabIndex = 26;
            lstCategoria.SelectedIndexChanged += lstServicoExterno_SelectedIndexChanged;
            // 
            // lstEstado
            // 
            lstEstado.AccessibleName = "";
            lstEstado.FormattingEnabled = true;
            lstEstado.Location = new Point(1120, 287);
            lstEstado.Name = "lstEstado";
            lstEstado.Size = new Size(210, 184);
            lstEstado.TabIndex = 27;
            lstEstado.SelectedIndexChanged += lstEstado_SelectedIndexChanged;
            // 
            // lstPrioridade
            // 
            lstPrioridade.FormattingEnabled = true;
            lstPrioridade.Location = new Point(1120, 481);
            lstPrioridade.Name = "lstPrioridade";
            lstPrioridade.Size = new Size(210, 199);
            lstPrioridade.TabIndex = 28;
            lstPrioridade.SelectedIndexChanged += lstPrioridade_SelectedIndexChanged;
            // 
            // btnRemoverLP
            // 
            btnRemoverLP.Location = new Point(1026, 686);
            btnRemoverLP.Name = "btnRemoverLP";
            btnRemoverLP.Size = new Size(88, 23);
            btnRemoverLP.TabIndex = 29;
            btnRemoverLP.Text = "Remover LP";
            btnRemoverLP.UseVisualStyleBackColor = true;
            btnRemoverLP.Click += btnRemoverLP_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(247, 686);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 30;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(1361, 711);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemoverLP);
            Controls.Add(lstPrioridade);
            Controls.Add(lstEstado);
            Controls.Add(lstCategoria);
            Controls.Add(label7);
            Controls.Add(rdbCompleto);
            Controls.Add(rdbSimples);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCliente);
            Controls.Add(cmbFuncionario);
            Controls.Add(cmbPrioridade);
            Controls.Add(cmbEstado);
            Controls.Add(cmbCategoria);
            Controls.Add(btnRemover);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvLP);
            Controls.Add(dgvProcesso);
            Controls.Add(btnLP);
            Controls.Add(btnProcesso);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Clientes";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProcesso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionáriosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem processosToolStripMenuItem;
        private Button btnProcesso;
        private Button btnLP;
        private DataGridView dgvProcesso;
        private DataGridView dgvLP;
        private Label label1;
        private Label label2;
        private Button btnRemover;
        private ComboBox cmbCategoria;
        private ComboBox cmbEstado;
        private ComboBox cmbPrioridade;
        private ComboBox cmbFuncionario;
        private ComboBox cmbCliente;
        private Label lblCategoria;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rdbSimples;
        private RadioButton rdbCompleto;
        private Label label7;
        private ListBox lstCategoria;
        private ListBox lstEstado;
        private ListBox lstPrioridade;
        private ToolStripMenuItem estadosToolStripMenuItem;
        private Button btnRemoverLP;
        private Button btnLimpar;
    }
}
