using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscolar.Entidades.PersonContext.EnumContext;
using SistemaEscolar.Entidades.PersonContext;

namespace SistemaEscolar.Entidades.MenuContext
{
    public static class View
    {
        public static int ViewMenu()
        {
            Console.WriteLine("======= Painel de Administração =======");
            Console.WriteLine("[0] Sair");
            Console.WriteLine("[1] Adicionar Professor");
            Console.WriteLine("[2] Adicionar Aluno");
            Console.WriteLine("[3] Listar Professor");
            Console.WriteLine("[4] Criar uma turma");
            Console.WriteLine("=======================================");
            Console.WriteLine("Qual opção voce deseja ?");
            return int.Parse(Console.ReadLine());
        }

        public static Professor ViewMontarProfessor(int id)
        {
            Console.WriteLine("======= Painel de Professores =======");

            #region Nome

            Console.WriteLine("Nome do professor: ");
            string nome = Console.ReadLine();

            #endregion

            #region Cpf

            Console.WriteLine("cpf do professor: ");
            string cpf = Console.ReadLine();

            #endregion

            #region Materia

            Console.WriteLine("Materia: ");
            string materia = Console.ReadLine();

            #endregion

            #region Sexo

            Console.WriteLine("Genero do professor: ");
            Console.WriteLine($"[{0}]{EGender.Masculino}");
            Console.WriteLine($"[{1}]{EGender.Feminino}");
            var genero = (EGender)int.Parse(Console.ReadLine());

            #endregion

            bool ativo = true;

            return new Professor(id, nome, genero, cpf, materia, ativo);
        }
        public static string ViewMontarTurma()
        {
            Console.WriteLine("Codigo Da turma:");
            string codigoTurma = Console.ReadLine();
            return codigoTurma;
        }
        public static Aluno ViewMontarAluno(int id)
        {
            Console.WriteLine("======= Painel de Alunos =======");

            #region Nome

            Console.WriteLine("Nome do Aluno: ");
            string nome = Console.ReadLine();

            #endregion

            #region Cpf

            Console.WriteLine("cpf do aluno: ");
            string cpf = Console.ReadLine();

            #endregion

            #region Sexo
            Console.WriteLine("Genero do aluno: ");
            Console.WriteLine($"[{0}]{EGender.Masculino}");
            Console.WriteLine($"[{1}]{EGender.Feminino}");
            var genero = (EGender)int.Parse(Console.ReadLine());

            #endregion

            return new Aluno(id, nome, genero, cpf);
        }
    }
}
