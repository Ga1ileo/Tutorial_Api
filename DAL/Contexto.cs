using System;
using Microsoft.EntityFrameworkCore;
using Tutorial_Api.Models;

namespace Tutorial_Api.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Visitas> Visitas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite(@"Data Source=Data\PruebaApi.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Crear Departamentos directos en la base de datos
            modelBuilder.Entity<Visitas>().HasData(new Visitas { VisitaId = 1, Fecha = DateTime.Now  ,Nombres = "Miguel Jose"  });
            
        }
    }
}