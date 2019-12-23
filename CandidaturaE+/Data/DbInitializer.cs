using CandidaturaE_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaE_.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();
            //if (!context.Utilizador.Any())
            //{// Adicionar Marcas para testes
            //    context.Utilizador.Add(new Utilizador {
            //        CodigoIPS = 1111 , 
            //        Nome = "Ana", 
            //        Telefone = 911
            //    });
            //    context.Utilizador.Add(new Utilizador {
            //        CodigoIPS = 1112, 
            //        Nome = "Catia"
            //    });
            //    context.Utilizador.Add(new Utilizador {
            //        CodigoIPS = 1113, 
            //        Nome = "Beatriz"
            //    });

                context.SaveChanges();  //é necessário gravar de imediato
                                        // para se poder usar as FK nos carros         
            }
        }
    }
//}
