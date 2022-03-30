using SistemaEscolar.Entidades.Interface;
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
        public School(int id, string name, Diretor diretor)
        {
            Id = id;
            Name = name;
            Professores = new List<Professor>();
            Turmas = new List<Turma>();
            Alunos = new List<Aluno>();
            Cordenacao = new Cordenacao(diretor);
            Pessoas = new List<Pessoa>();
        }

        /*Se toda vez que eu for criar um tipo de pessoa diferente, eu tiver que modificar essa classe para acrecentar 
         mais um metodo, como posso manter a segunrança dela ? ela tem que mudar por apenas um motivo e nao para varios*/
        public void Guardar(ICriar criador)
        {
            List<Pessoa> pessoas = criador.Criar();
            Pessoas.AddRange(pessoas);
        }

        #region Gerenciando professor

        /*O professor ate pode ficar inativo, isso quer dizer que ele parou de dar aula mas para um professor
         entrar numa escola ele tem que estar pronto para dar aula*/
        public void AdicionarProfessor(Professor professor)
        {

            // tecnicamente um professor nunca vai ser false pq o construtor ja fala que ele é ativo
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
            Cordenacao.DesativarProfessor(RetornarProfessor(cpf));
            return true;
        }

        // esse metodo só vai fazer sentido se eu utilizar em outras partes
        public bool ProfessorAtivo(Professor professor)
        {
            if (!professor.Ativo)
            {
                throw new Exception("Esse professor nao esta mais dando aulas ");
            }
            return true;
        }

        // Talvez isto estaria melhor dentro de um repository de professor
        public Professor RetornarProfessor(string cpf)
        {
            Pessoa professor = Pessoas.FirstOrDefault(professor => professor.Cpf == cpf);

            if (professor == null)
                throw new Exception("O professor selecionado nao esta cadastro em nosso banco de dados!");

            return (Professor)professor;
        }

        #endregion

        #region Gerenciando a turma 
        public Turma RetornarTurma(string codigo)
        {
            Turma turmaEscolhida = Turmas.FirstOrDefault(t => t.Codigo == codigo);
            if (turmaEscolhida == null)
                throw new Exception("A Turma escolhida nao existe em nosso banco de dados ");
            return turmaEscolhida;
        }
        public void IniciarTurma(int id, string codigoTurma, Professor professor)
        {
            ProfessorAtivo(professor);
            Turma turma = new(id, codigoTurma, professor, Alunos);
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
        public void AdicionarAlunos(List<Aluno> alunos)
        {
            Alunos.AddRange(alunos);
        }

        // Lista os alunos da escola inteira
        public void ListarAlunos()
        {
            int x = 1;
            foreach (Aluno aluno in Alunos)
            {
                Console.WriteLine($"[{x}] {aluno.Name}");
                x++;
            }
            Console.WriteLine();
        }


        #endregion

        #region Propriedades

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Professor> Professores { get; private set; }
        public List<Turma> Turmas { get; private set; }
        public List<Aluno> Alunos { get; private set; }
        public Cordenacao Cordenacao { get; private set; }

        public List<Pessoa> Pessoas { get; private set; }

        #endregion

    }
}
