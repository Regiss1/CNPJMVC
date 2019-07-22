using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNPJMVC.Models
{
    public class Employee
    {
        [Key]
        public int IdLoja { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required]
        public int CNPJ { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public int NomeCompleto { get; set; }
    }
}
