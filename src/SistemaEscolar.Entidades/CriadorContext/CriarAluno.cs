using SistemaEscolar.Entidades.Interface;
using SistemaEscolar.Entidades.MenuContext;
using SistemaEscolar.Entidades.PersonContext;
using SistemaEscolar.Entidades.SchoolContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.CriadorContext
{
    public class CriarAluno : ICriar
    {
        public List<Pessoa> Criar(School escola)
        {
            int idAluno = 0;
            List<Pessoa> Alunos = new List<Pessoa>();
            while (true)
            {
                Aluno aluno = View.ViewMontarAluno(idAluno);
                Alunos.Add(aluno);
                escola.Alunos.Add(aluno);

                Console.WriteLine("Deseja continuar ? (S):(N)");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "n")
                    break;
                idAluno += 1;

            }
            return Alunos;
        }
    }
}
