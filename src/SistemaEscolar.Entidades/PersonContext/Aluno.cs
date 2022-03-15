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
        public Aluno(int id, string name, EGender gender, string cpf) : base(id, name, gender, cpf)
        {
        }
    }
}
