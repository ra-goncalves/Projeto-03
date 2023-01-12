using RF.Projeto03.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RF.Projeto03.UI.Data
{
    public class Projeto03DataContext:DbContext
    {
        public Projeto03DataContext():base("ProjetoConn")
        {
        }

        public DbSet<Colaboradores> Colaboradores { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}