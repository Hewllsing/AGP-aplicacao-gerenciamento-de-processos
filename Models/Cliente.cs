using System.ComponentModel.DataAnnotations;

namespace AGP.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string? NomeCliente { get; set; }

        public string? Referencia { get; set; }

    }
}
