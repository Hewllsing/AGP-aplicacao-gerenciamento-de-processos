using AGP.Models;
using Microsoft.EntityFrameworkCore;

namespace AGP.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estado> Estados { get; set; }   
        public DbSet<LinhaProcesso> LinhasProcessos { get; set; }
        public DbSet<Prioridade> Prioridades { get; set; }
        public DbSet<Processo> Processos { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Só configura se ainda não estiver configurado
            if (!optionsBuilder.IsConfigured)
            {
               
                optionsBuilder.UseSqlServer("Server=62.28.39.135,62444;Database=AGP_06_Leonardo;user=efa0125;password=efa0125@;TrustServerCertificate=True;");
            }
        }
    }
}




