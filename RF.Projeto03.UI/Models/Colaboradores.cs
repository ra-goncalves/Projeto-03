using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Resources;
using System.Web;

namespace RF.Projeto03.UI.Models
{
    public class Colaboradores
    {

        [Key]public int idColaboradores { get; set; }

        [Required(ErrorMessage = "O campo nome não pode estar em branco.")]
        public string nomeColab { get; set; }

        [Required(ErrorMessage = "O campo idade não pode estar em branco.")]

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")] public DateTime idade { get; set; }

        [Display(Name = "email")]
        [EmailAddress]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Digite um email valido")]
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato de email invalido")]
        public string emailColab { get; set; }

        [Required(ErrorMessage = "O campo endereço não pode estar em branco.")]
        public string endereco { get; set; }

        public string outrasInfo { get; set; }

        public string interesses { get; set; }

        public string sentimentos { get; set; }

        public string valores { get; set; }

        public DateTime datacadColab { get; set; } = DateTime.Now;

        public string Inativo { get; set; }

    }
}