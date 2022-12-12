using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RF.Projeto03.UI.Models
{
    public class Usuarios
    {
        public int idUsuarios { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public DateTime datacad { get; set; }
    }
}