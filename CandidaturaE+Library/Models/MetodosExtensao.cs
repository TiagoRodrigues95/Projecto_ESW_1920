using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidaturaE_Library.Models
{
    public static class MetodosDeExtensao
    {

        public static String ListaEmpresas(this List<Empresa> Empresas)
        {
            StringBuilder stb = new StringBuilder("{");
            String virgula = "";
            foreach (Empresa emp in Empresas)
            {
                stb.Append(virgula + emp.ToString());
                virgula = (virgula == "") ? ", " : virgula; // ou mais simples virgula=", ";
            }
            stb.Append("}");
            return stb.ToString();
        }

        public static String ListaAlunos(this List<Aluno> Alunos)
        {
            StringBuilder stb = new StringBuilder("{");
            String virgula = "";
            foreach (Aluno a in Alunos)
            {
                stb.Append(virgula + a.Nome);
                virgula = (virgula == "") ? ", " : virgula; // ou mais simples virgula=", ";
            }
            stb.Append("}");
            return stb.ToString();
        }
    }
}

