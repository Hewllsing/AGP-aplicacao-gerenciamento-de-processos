using AGP.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AGP
{
    public partial class FormLixo : Form
    {
        public FormLixo()
        {
            InitializeComponent();
        }

        void LoadClientes()
        {
            using var db = new Data.AppDbContext();
            dgv.DataSource = db.Clientes.ToList();


        }

        private void FormLixo_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = true;
            //dgv.Dock = DockStyle.Fill;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // deixa a grid estendida de acordo com o tamanho das celulas

            LoadClientes();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using var db = new Data.AppDbContext();
            var cliente = new Models.Cliente();
            cliente.NomeCliente = txtAdd.Text;
            cliente.Referencia = txtEndereco.Text;
            
            if (cliente != null)
            { 
                db.Clientes.Add(cliente);
                db.SaveChanges();
                LoadClientes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using var db = new Data.AppDbContext();
            Cliente cliente = new Cliente();

            var id = (int)dgv.CurrentRow.Cells["Id"].Value;
            cliente.Id = id;
            cliente.NomeCliente = (string)dgv.CurrentRow.Cells["NomeCliente"].Value;
            cliente.Referencia = (string)dgv.CurrentRow.Cells["Referencia"].Value;

            if (cliente != null)
            {
                 db.Clientes.Update(cliente);
                 db.SaveChanges();
                 LoadClientes();
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            using var db = new Data.AppDbContext();
            Cliente cliente = new Cliente();
            var id = (int)dgv.CurrentRow.Cells["Id"].Value;
            cliente.Id = id;

            if (cliente != null)
            {
                db.Clientes.Remove(cliente);
                db.SaveChanges();
                LoadClientes();
            }
        }
    }
}
