using SistemaEscolar.Entidades.PersonContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.SchoolContext
{
    public class Cordenacao
    {
        public Diretor DiretorAtual { get; set; }

        public Cordenacao(Diretor diretor)
        {
            DiretorAtual = diretor;
        }
        public void FecharTurma(Turma turma)
        {
            turma.FecharTurma();
        }
        public bool DesativarProfessor(Professor professor)
        {
            try
            {
                professor.Ativo = false;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Por algum motivo não podemos demitir o professor {professor.Name}");
                return false;
            }
        }
    }
}
