using CandidaturaE_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if ( /*NOT*/ !context.Empresa.Any())
            {
                // Adicionar Marcas para testes
                context.Empresa.Add(
                    new Empresa { 
                        Nome = "Ferrary Inc",
                        Representante = "Miguel",
                        Contacto = "855"
                    });
                context.Empresa.Add(
                    new Empresa {
                        Nome = "Porche Inc",
                        Representante = "Ana",
                        Contacto = "035"
                    });
                context.Empresa.Add(
                    new Empresa {
                        Nome = "BMW Corp",
                        Representante = "Ricardo",
                        Contacto = "921"
                    });
                context.SaveChanges();
                //antes de se usar as FK das marcas na adicão de carros, 
                //tem que se chamar SaveChanges, ou daria um "FK error"
            }
        }
    }
}
