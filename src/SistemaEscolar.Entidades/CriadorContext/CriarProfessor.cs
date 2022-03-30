using SistemaEscolar.Entidades.Interface;
using SistemaEscolar.Entidades.MenuContext;
using SistemaEscolar.Entidades.PersonContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.CriadorContext
{
    public class CriarProfessor : ICriar
    {
        // antes esse codigo estava solto no program.cs. ao meu ver isto esta errado, pois deve estar encapsulado
        public List<Pessoa> Criar()
        {
            int idProfessor = 0;
            List<Pessoa> professores = new List<Pessoa>();
            while (true)
            {
                Professor professor = View.ViewMontarProfessor(idProfessor);
                professores.Add(professor);

                Console.WriteLine("Deseja continuar ? (S):(N)");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "n")
                    break;
                idProfessor += 1;

            }
            return professores;
        }
    }
}
