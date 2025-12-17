using System;
using System.Linq;
using System.Windows.Forms;
using AGP.Data;
using AGP.Models;

namespace AGP.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Configura DataGridView no Form
            dataGridView1.AutoGenerateColumns = true;
            LoadClientes();
        }
        private void LoadClientes()
        {//carregar os clientes e colocá-los na grid:
            using var db = new AppDbContext();
            dataGridView1.DataSource = db.Clientes.ToList();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {//o cliente que está na caixa é adicionado à grid:
            using var db = new AppDbContext();
            var cliente = new Cliente { NomeCliente = txtNome.Text };
            db.Clientes.Add(cliente);
            db.SaveChanges();//atualizar a base de dados
            LoadClientes();//recarregar a grid a partir da base de dados
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {//o cliente que está na caixa de texto é removido da grid:
            if (dataGridView1.CurrentRow == null) return;
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            using var db = new AppDbContext();
            var cliente = db.Clientes.Find(id);
            if (cliente != null)
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
                LoadClientes();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes fc = new FormClientes();
            fc.ShowDialog();

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionarios ff = new FormFuncionarios();
            ff.ShowDialog();
        }
    }
}
