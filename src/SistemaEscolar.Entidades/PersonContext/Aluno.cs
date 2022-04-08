using SistemaEscolar.Entidades.PersonContext.EnumContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.PersonContext
{
    public class Aluno : Pessoa
    {
        public Aluno(int id, string name, EnumContext.Enum gender, string cpf) : base(id, name, gender, cpf)
        {
            Ocupacao = EOcupação.Aluno;
        }
    }
}
