using Microsoft.EntityFrameworkCore;
using Sisso.BE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sisso.DAL
{
    public class SissoContext : DbContext
    {
        //Controlar las cadenas de conexión
        //public SissoContext(string connString) : base(connString)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"data source=.;User ID=sa;Password=mompi3p;Initial Catalog=Sisso;",
                    options => options.ExecutionStrategy(c => new MyExecutionStrategy(c))
                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // equivalent of modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                //entityType.Relational().TableName = entityType.DisplayName();

                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                // and modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            /*
             * https://www.learnentityframeworkcore.com/migrations/seeding
             * If you prefer to keep your OnModelCreating method clean, you can 
             * refactor these operations into an extension method on the 
             * ModelBuilder: ModelBuilderExtensions.
             * Then you can call the Seed method in OnModelCreating:
             */

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Persona> Personas { get; set; }
    }
}