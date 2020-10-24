using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial_Api.DAL;
using Tutorial_Api.Models;

namespace Tutorial_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitasController : ControllerBase
    {
        [HttpGet("{Nombres}")]
        public Visitas Get (string nombre){
            
            Contexto contexto = new Contexto();

            var visita = new Visitas() {Nombres = nombre};

            contexto.Visitas.Add(visita);

            contexto.SaveChanges();
            contexto.Dispose();

            return visita;

        }

        [HttpGet]
        public List<Visitas> GetVisitas(){
            Contexto contexto = new Contexto();
            
            var lista = contexto.Visitas.AsNoTracking().ToList();

            contexto.SaveChanges();
            contexto.Dispose();

            return lista;
        }


        // public Visitas Buscar(string nombre){
        //     Contexto contexto = new Contexto();
            
        //     var buscarNombre = contexto.Visitas.Find(nombre);

        //     contexto.SaveChanges();
        //     contexto.Dispose();

        //     return buscarNombre;

        // }
    }
}