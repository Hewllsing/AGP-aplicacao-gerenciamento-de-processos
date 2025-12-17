using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AGP.Models
{
  
    public class LinhaProcesso
    {
        public int Id { get; set; }

      
        public DateTime? Data { get; set; }

      
        public string Texto { get; set; }

       
        public int? ProcessoId { get; set; }

     
        public int? FuncionarioId { get; set; }

       
    }  
}
