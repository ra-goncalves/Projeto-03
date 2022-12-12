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
        public Projeto03DataContext():base(@"Data Source=RAFAEL\SQLRAFAEL;Initial Catalog=Projeto2;Integrated Security=True")
        {
            Database.SetInitializer<Projeto03DataContext>(null);
        }

        public DbSet<Colaboradores> Colaboradores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}