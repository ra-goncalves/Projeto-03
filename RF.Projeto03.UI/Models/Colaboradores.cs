using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RF.Projeto03.UI.Models
{
    public class Colaboradores
    {
        
        [Key]public int idColaboradores { get; set; }

        public string nomeColab { get; set; }

        [Column(TypeName = "Date")] public DateTime idade { get; set; }

        public string emailColab { get; set; }

        public string endereco { get; set; }

        public string outrasInfo { get; set; }

        public string interesses { get; set; }

        public string sentimentos { get; set; }

        public string valores { get; set; }

        public DateTime datacadColab { get; set; } = DateTime.Now;

    }
}