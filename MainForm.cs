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
            cmbCategoria.DisplayMember = "Designacao";
            cmbCategoria.ValueMember = "Id";
            cmbEstado.SelectedIndex = -1; // Nenhum item selecionado inicialmente

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

        // Filtra os processos pela categoria selecionada no ComboBox
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filtra os processos pela categoria selecionada no ComboBox
            if (carregarGrid == true || cmbCategoria.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Categoria categoriaSelecionada = cmbCategoria.SelectedItem as Categoria; // Obtém a categoria selecionada no ComboBox

                if (categoriaSelecionada == null)
                {
                    return;
                }
                else
                {
                    dgvProcesso.DataSource = db.Processos.Where(m => m.CategoriaId == categoriaSelecionada.Id).ToList(); // Filtra os processos pela categoria selecionada
                }
            }
        }

        // Filtra os processos pelo estado selecionado no ComboBox
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {   // Filtra os processos pelo estado selecionado no ComboBox
            if (carregarGrid == true || cmbEstado.SelectedIndex == -1) //  Verifica se o grid está pronto para carregar ou se nenhum estado está selecionado
            {
                return;
            }
            else
            {
                Estado EstadoSelecionada = cmbEstado.SelectedItem as Estado; // Obtém a categoria selecionada no ComboBox

                if (EstadoSelecionada == null)
                {
                    return;
                }
                else
                {
                    dgvProcesso.DataSource = db.Processos.Where(m => m.Estado == EstadoSelecionada.Id).ToList(); // Filtra os processos pelo Estado selecionado
                }
            }
        }


    }
}
