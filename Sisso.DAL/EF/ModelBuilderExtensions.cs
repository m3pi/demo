using System;
using Microsoft.EntityFrameworkCore;
using Sisso.BE.Entities;

namespace Sisso.DAL
{
    public static class ModelBuilderExtensions
    {
        public static void Seet(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasData(
                new Persona { ApellidoMaterno = "Guarniz", ApellidoPaterno = "Saavedra", NroDoi = "47701560", PrimerNombre = "Oscar", SegundoNombre = "Geny" },
                new Persona { ApellidoMaterno = "Urteaga", ApellidoPaterno = "Bazan", NroDoi = "87654321", PrimerNombre = "Anderson", SegundoNombre = "Kevin" }
            );

        }
    }
}
