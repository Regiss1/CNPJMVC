using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNPJMVC.Models
{
    public class Loja
    {
        [Key]
        public int IdLoja { get; set; }
        [Column(TypeName ="nvarchar(11)")]
        [Required(ErrorMessage ="Este Campo é obrigatório")]
        public int CNPJ { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DisplayName("Nome Completo")]
        public string Nome_Completo { get; set; }
    }
}
