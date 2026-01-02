using System;
using System.Linq;
using System.Windows.Forms;
using AGP.Data;
using AGP.Models;
using AGP;
using Microsoft.Identity.Client.Extensibility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AGP.Forms
{
    public partial class MainForm : Form
    {
        // Variável para controlar o carregamento inicial do grid
        bool carregarGrid = true;

        // Instância do AppDbContext do banco de dados
        AppDbContext db = new AppDbContext(); // Instancia o context do banco de dados
        BindingSource bs = new BindingSource(); // Cria um BindingSource para gerenciar os dados vinculados

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Configurações iniciais do DataGridView
            dgvProcesso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Configura o DataGridView para ajustar o tamanho das colunas automaticamente
            dgvProcesso.AutoGenerateColumns = true; // Configura o DataGridView para gerar colunas automaticamente
            dgvLP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLP.AutoGenerateColumns = true;

            // Carrega as categorias no ComboBox
            db.Categorias.Load();
            cmbCategoria.DataSource = db.Categorias.Local.ToList();
            cmbCategoria.DisplayMember = "Designacao";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1; // Nenhum item selecionado inicialmente

            // Carrega os estados no ComboBox
            db.Estados.Load();
            cmbEstado.DataSource = db.Estados.Local.ToList();
            cmbEstado.DisplayMember = "Designacao";
            cmbEstado.ValueMember = "Id";
            cmbEstado.SelectedIndex = -1; // Nenhum item selecionado inicialmente

            // Carrega as prioridades no ComboBox
            db.Prioridades.Load();
            cmbPrioridade.DataSource = db.Prioridades.Local.ToList();
            cmbPrioridade.DisplayMember = "Designacao";
            cmbPrioridade.ValueMember = "Id";
            cmbPrioridade.SelectedIndex = -1; // Nenhum item selecionado inicialmente

            // Carrega os funcionarios no ComboBox
            db.Funcionarios.Load();
            cmbFuncionario.DataSource = db.Funcionarios.Local.ToList();
            cmbFuncionario.DisplayMember = "NomeFuncionario";
            cmbFuncionario.ValueMember = "Id";
            cmbFuncionario.SelectedIndex = -1; // Nenhum item selecionado inicialmente

            // Carrega os clientes no ComboBox
            db.Clientes.Load();
            cmbCliente.DataSource = db.Clientes.Local.ToList();
            cmbCliente.DisplayMember = "NomeCliente";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedIndex = -1; // Nenhum item selecionado inicialmente

            carregarGrid = false;
        }

        // ---------------------------------------------------------------
        //                       MENU STRIP
        // ---------------------------------------------------------------





        // Exibe o form clientes
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formClientes = new FormClientes(); // Cria o formulário de clientes
            formClientes.Show(); // Exibe o formulário de clientes

        }

        // Exibe o form funcionários
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Exibe o form categorias 
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCategorias = new FormCategorias(); // Cria o formulário de categorias
            formCategorias.Show(); // Exibe o formulário de categorias
        }

        // Exibe o form estados
        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formEstados = new FormEstados(); // Cria o formulário de estados
            formEstados.Show(); // Exibe o formulário de estados
        }



        // ---------------------------------------------------------------
        //                       PROCESSOS
        // ---------------------------------------------------------------

        // Exibe todas as linhas de processo no DataGridView
        private void btnProcesso_Click(object sender, EventArgs e)
        {
            db.Processos.Load();
            bs.DataSource = db.Processos.Local.ToBindingList();
            dgvProcesso.DataSource = bs.DataSource; // Define o DataSource do DataGridView para o BindingSource

            bs.EndEdit();
            db.SaveChanges();

        }

        // Exibe todas as linhas de processo no DataGridView
        private void btnLP_Click(object sender, EventArgs e)
        {
            db.LinhasProcessos.Load();
            bs.DataSource = db.LinhasProcessos.Local.ToBindingList();
            dgvLP.DataSource = bs.DataSource; // Define o DataSource do DataGridView para o BindingSource


            bs.EndEdit();
            db.SaveChanges();
        }

        // Salva as alterações feitas nas células do DataGridView
        private void dgvProcesso_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();
        }

        // Salva as alterações feitas nas células do DataGridView
        private void dgvLP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();
        }

        // Remover o processo selecionado no DataGridView
        private void btnRemover_Click_1(object sender, EventArgs e)
        {   // PROBLEMA REMOVE DAS DUAS GRID
            if (dgvProcesso.CurrentRow != null)
            {
                Processo processo = new Processo();

                var idProcesso = Convert.ToInt32(dgvProcesso.CurrentRow.Cells["Id"].Value);
                processo = db.Processos.Find(idProcesso);

                if (processo != null)
                {
                    db.Processos.Remove(processo);
                    db.SaveChanges();
                }
            }
        }

        private void btnRemoverLP_Click(object sender, EventArgs e)
        {
            if (dgvLP.CurrentRow != null) // Verifica se há uma linha selecionada no DataGridView
            {
                LinhaProcesso linhaProcesso = new LinhaProcesso();

                var idLP = Convert.ToInt32(dgvLP.CurrentRow.Cells["Id"].Value); // Pega o Id da linha selecionada
                linhaProcesso = db.LinhasProcessos.Find(idLP); // Encontra a LinhaProcesso no banco de dados pelo Id

                if (linhaProcesso != null)
                {
                    db.LinhasProcessos.Remove(linhaProcesso);
                    db.SaveChanges();
                }
            }
            bs.EndEdit(); // Finaliza a edição do BindingSource
        }


        // ---------------------------------------------------------------
        //               FILTRO DE PROCESSOS
        // ---------------------------------------------------------------

        // Instância da classe responsável por aplicar os filtros nos processos
        ProcessoFilter filter = new ProcessoFilter();


        // Método central que aplica todos os filtros de forma cumulativa
        private void AplicarFiltros()
        {
            // Evita aplicar filtros enquanto o grid ainda está carregando
            if (carregarGrid) return;

            // Chama a classe de filtro, passando:
            // - a consulta base dos processos
            // - os valores selecionados nos ComboBox (se existirem)
            var query = filter.FiltrarProcessos(
                db.Processos,
                cmbCategoria.SelectedItem as Categoria,
                cmbEstado.SelectedItem as Estado,
                cmbPrioridade.SelectedItem as Prioridade,
                cmbFuncionario.SelectedItem as Funcionario,
                cmbCliente.SelectedItem as Cliente
            );

            // Atualiza o DataGridView com o resultado filtrado
            dgvProcesso.DataSource = query.ToList();
        }


        // Evento disparado ao alterar a categoria selecionada no ComboBox
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reaplica todos os filtros considerando a nova categoria
            AplicarFiltros();
        }


        // Evento disparado ao alterar o estado selecionado no ComboBox
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reaplica todos os filtros considerando o novo estado
            AplicarFiltros();
        }


        // Evento disparado ao alterar a prioridade selecionada no ComboBox
        private void cmbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reaplica todos os filtros considerando a nova prioridade
            AplicarFiltros();
        }


        // Evento disparado ao alterar o funcionário selecionado no ComboBox
        private void cmbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reaplica todos os filtros considerando o novo funcionário
            AplicarFiltros();
        }


        // Evento disparado ao alterar o cliente selecionado no ComboBox
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reaplica todos os filtros considerando o novo cliente
            AplicarFiltros();

        }
    }
}