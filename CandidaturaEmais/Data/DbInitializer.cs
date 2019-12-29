using CandidaturaEmais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidaturaEmais.Data
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
            //
            //    context.SaveChanges();  //é necessário gravar de imediato
            //                            // para se poder usar as FK nos carros         
            //}

            //context.Database.EnsureCreated();

            //// adicionar notificações
            //if (!context.Notificacao.Any()) {
            //    // notifica criação de conta
            //    context.Notificacao.Add(new Notificacao {
            //        Para = "150221081@estudantes.ips.pt",
            //        Assunto = "Bem-vindo",
            //        Mensagem = "A CandidaturaE+ dá-lhe as boas vindas. Verifica tudo o que pode fazer na plataforma!",
            //        Timestamp = new DateTime(2019, 20, 12, 15, 24, 16)
            //    });

            //    // notifica disponibilidade de inquérito para responder
            //    context.Notificacao.Add(new Notificacao {
            //        Para = "150221081@estudantes.ips.pt",
            //        Assunto = "Inquérito disponível",
            //        Mensagem = "Encontra-se um inquérito disponível para responder.",
            //        Timestamp = DateTime.Now
            //    });

            //    // notifica submissão de inquérito
            //    context.Notificacao.Add(new Notificacao {
            //        Para = "150221081@estudantes.ips.pt",
            //        Assunto = "Submeteu inquérito",
            //        Mensagem = "Inquérito submetido com sucesso.",
            //        Timestamp = new DateTime(2020, 1, 1, 02, 59, 10)
            //    });

            //    context.SaveChanges();
            //}
        }
    }
}
