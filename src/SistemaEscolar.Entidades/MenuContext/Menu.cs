using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscolar.Entidades.PersonContext.EnumContext;
using SistemaEscolar.Entidades.PersonContext;

namespace SistemaEscolar.Entidades.MenuContext
{
    public static class Menu
    {
        public static int ShowMenu()
        {
            Console.WriteLine("======= Painel de Administração =======");
            Console.WriteLine("[0] Sair");
            Console.WriteLine("[1] Adicionar Professor");
            Console.WriteLine("[2] Listar Professor");
            Console.WriteLine("=======================================");
            Console.WriteLine("Qual opção voce deseja ?");
            return int.Parse(Console.ReadLine());
        }

        public static Professor ShowMontarProfessor(int id)
        {
            Console.WriteLine("======= Painel de Professores =======");
            Console.WriteLine("Nome do professor: ");
            string nome = Console.ReadLine();
            Console.WriteLine("cpf do professor: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Materia: ");
            string materia = Console.ReadLine();

            Console.WriteLine("Genero do professor: ");
            var genero = Console.ReadLine().ToLower();

            EGender generoEscolhido;

            bool ativo = true;

            switch (genero)
            {
                case "masculino":
                    generoEscolhido = EGender.Masculino;
                    break;

                case "feminino":
                    generoEscolhido = EGender.Feminino;
                    break;

                default:
                    throw new Exception("Ainda nao temos outros tipos de generos");
            }

            return new Professor(id, nome, generoEscolhido, cpf, materia, ativo);
        }
    }
}
