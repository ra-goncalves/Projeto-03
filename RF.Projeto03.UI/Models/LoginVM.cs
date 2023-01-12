using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RF.Projeto03.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O campo email não pode estar em branco.")]
        public string email { get; set; }
        [Required(ErrorMessage = "O campo senha não pode estar em branco.")]

        public string senha { get; set; }

        public string ReturnURL { get; set; }
    }
}