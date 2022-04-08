using SistemaEscolar.Entidades.PersonContext.EnumContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.PersonContext
{
    public class Pessoa
    {
        public Pessoa(int id, string name, EnumContext.Enum gender, string cpf)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Cpf = cpf;
        }

        public int Id { get; private set; }
        public string? Name { get; private set; }
        public EnumContext.Enum? Gender { get; private set; }
        public string? Cpf { get; private set; }
        public EOcupação Ocupacao { get; protected set; }
    }
}
