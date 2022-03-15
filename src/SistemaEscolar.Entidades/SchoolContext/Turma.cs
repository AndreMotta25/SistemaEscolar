using SistemaEscolar.Entidades.PersonContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.SchoolContext
{
    public class Turma
    {
        public Turma(int id, string codigo, Professor professor, List<Aluno> alunos)
        {
            Id = id;
            Codigo = codigo;
            Professor = professor;
            Alunos = alunos;
            Aberta = true;
            DataAbertura = DateTime.Now.AddDays(-1);
            DataFechamento = null;
        }
        public void FecharTurma()
        {
            Aberta = false;
            DataFechamento = DateTime.Now;
        }
        public void ListarAlunos()
        {
            Console.Write("[");
            foreach (var aluno in Alunos)
            {
                Console.Write(" " + aluno.Name + ", ");
            }
            Console.WriteLine("]");
        }

        public void InfoTurma()
        {
            Console.WriteLine($"========= Turma {Codigo} =========");
            Console.WriteLine($"Professor:{Professor.Name} ");
            Console.WriteLine($"Status: {(Aberta ? "Aberta" : "Fechada")}");
            Console.WriteLine($"Data de Abertura: {DataAbertura} ");
            Console.WriteLine($"Data de Fechamento: {(Aberta ? "Em progresso" : DataFechamento)}");
            Console.Write($"Alunos:");
            ListarAlunos();
        }

        public int Id { get; private set; }
        public string Codigo { get; private set; }
        public Professor Professor { get; private set; }
        public List<Aluno> Alunos { get; private set; }
        public bool Aberta { get; set; }

        public DateTime DataAbertura { get; private set; }
        public DateTime? DataFechamento { get; private set; }
    }

}
