using AGP.Data;
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
    public partial class FormCategorias : Form
    {
        AppDbContext db = new AppDbContext();
        BindingSource bs = new BindingSource();
        public FormCategorias()
        {
            InitializeComponent();
            db.Categorias.Load();
            bs.DataSource = db.Categorias.Local.ToBindingList();
            dgv.DataSource = bs;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            db.SaveChanges();
            
        }
    }
}
