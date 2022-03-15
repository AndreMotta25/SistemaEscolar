using SistemaEscolar.Entidades.PersonContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.SchoolContext
{
    // gerenciador aplicacao escola
    public class School
    {
        public School(int id, string name)
        {
            Id = id;
            Name = name;
            Professores = new List<Professor>();
            Turmas = new List<Turma>();
            Alunos = new List<Aluno>();
        }

        /*O professor ate pode ficar inativo, isso quer dizer que ele parou de dar aula mas para um professor
         entrar numa escola ele tem que estar pronto para dar aula*/
        public void AdicionarProfessor(Professor professor)
        {
            if (professor.Ativo == true)
            {
                Professores.Add(professor);
                return;
            }
            // talvez esse regstro pode ser um cpf
            throw (new Exception("O professor para entrar na escola tem que estar com o registro ativo"));
        }

        public bool DesativarProfessor(string cpf)
        {
            Professor professorDemitido = RetornarProfessor(cpf);
            professorDemitido.Ativo = false;
            return true;
        }

        public List<Professor> ListarProfessores()
        {
            return Professores;
        }

        public bool ProfessorAtivo(Professor professor)
        {
            if (!professor.Ativo)
            {
                throw new Exception("Esse professor nao esta mais dando aulas ");
            }
            return true;
        }

        public Professor RetornarProfessor(string cpf)
        {
            Professor professor = Professores.FirstOrDefault(professor => professor.Cpf == cpf);
            if (professor == null)
                throw new Exception("O professor selecionado nao esta cadastro em nosso banco de dados!");
            return professor;
        }

        #region Gerenciando a turma 
        public Turma RetornarTurma(string codigo)
        {
            Turma turmaEscolhida = Turmas.FirstOrDefault(t => t.Codigo == codigo);
            if (turmaEscolhida == null)
                throw new Exception("A Turma escolhida nao existe em nosso banco de dados ");
            return turmaEscolhida;
        }
        public void IniciarTurma(int id, string codigoTurma, Professor professor, List<Aluno> alunos)
        {
            ProfessorAtivo(professor);
            Turma turma = new(id, codigoTurma, professor, alunos);
            Turmas.Add(turma);
        }
        public void ListarTurmas()
        {
            foreach (Turma turma in Turmas)
            {
                turma.InfoTurma();
            }
            Console.WriteLine("==========================");
        }


        #endregion

        #region Gerenciando alunos
        /* public void AdicionarAluno(List<Aluno> alunos)
         {
             Alunos.AddRange(alunos);
         }*/
        #endregion

        #region Propriedades
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Professor> Professores { get; private set; }
        public List<Turma> Turmas { get; private set; }
        public List<Aluno> Alunos { get; private set; }
        #endregion

    }
}
