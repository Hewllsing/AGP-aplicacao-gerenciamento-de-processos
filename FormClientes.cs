using AGP.Data;
using AGP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGP
{
    public partial class FormClientes : Form
    {
        AppDbContext db = new AppDbContext();
        BindingSource bs = new BindingSource();

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            db.Clientes.Load();
            bs.DataSource = db.Clientes.Local.ToBindingList();
            dgvClientes.DataSource = bs; // Define o DataSource do DataGridView para o BindingSource

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Configura o DataGridView para ajustar o tamanho das colunas automaticamente
        }

        private void btnOkClientes_Click(object sender, EventArgs e)
        {
            db.Clientes.Add(new Models.Cliente { NomeCliente = txtNomeCliente.Text, Referencia = txtRefCliente.Text }); // Adiciona um novo cliente ao banco de dados
            bs.EndEdit();
            db.SaveChanges();

            db.Clientes.Load(); // Recarrega os dados do banco de dados

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            Cliente cliente = new Cliente();

            var id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
            cliente.Id = id;
            cliente.NomeCliente = (string)dgvClientes.CurrentRow.Cells["NomeCliente"].Value;
            cliente.Referencia = (string)dgvClientes.CurrentRow.Cells["Referencia"].Value;

            db.Clientes.Update(cliente);
            db.SaveChanges();
            db.Clientes.Load(); // Recarrega os dados do banco de dados
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {   // Remover o cliente selecionado no DataGridView
            var db = new AppDbContext();
            Cliente cliente = new Cliente();

            var id = (int)dgvClientes.CurrentRow.Cells["Id"].Value;
            cliente.Id = id;    

            if (cliente != null)
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
                db.Clientes.Load();

                // Refresca o BindingSource com os dados atualizados
                bs.DataSource = db.Clientes.Local.ToBindingList();
                dgvClientes.DataSource = bs; // Atualiza o DataSource do DataGridView
            }
       }
    }
}
