using RF.Projeto03.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace RF.Projeto03.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<Projeto03DataContext>
    {
        protected override void Seed(Projeto03DataContext context)
        {
            var colaboradores = new List<Colaboradores>()
            {
                new Colaboradores() {nomeColab = "Rafael", emailColab = "rafael@gmail", outrasInfo= "outras info", 
                                   interesses = "interesses", sentimentos = "sentimentos", valores = "valores" }
            };
            context.Colaboradores.AddRange(colaboradores);

            context.Usuarios.Add(new Usuarios()
            {
                nome = "Rafael",
                email = "rafael@teste.com",
                senha = "1234"
            });
            context.SaveChanges();
        }
    }
}