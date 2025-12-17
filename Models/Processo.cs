using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AGP.Models
{
    public class Processo
    {
        public int Id { get; set; }
       
        public string? Titulo { get; set; }

        public string? Descricao { get; set; }

        public int? FuncionarioId { get; set; }

        public int? ClienteId { get; set; }
        
        public DateTime? DataCriacao { get; set; }

        public DateTime? DataLimite { get; set; }

        public bool TemCoima { get; set; }

        public int? SupervisorId { get; set; }

      
        public int? CategoriaId { get; set; }
      
        public int? PrioridadeId { get; set; }
      
        public int? Estado { get; set; }

    }
}
