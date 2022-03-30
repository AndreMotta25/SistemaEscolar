using SistemaEscolar.Entidades.PersonContext.EnumContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.PersonContext
{
    public class Professor : Pessoa
    {
        public Professor(int id, string name, EGender gender, string cpf, string materia, bool ativo) :
            base(id, name, gender, cpf)
        {
            Materia = materia;
            Ativo = ativo;
        }

        public override string ToString()
        {
            return $"Professor: {Name} Cpf: {Cpf} Sexo:{Gender} ";
        }

        // talvez usar um enum depois
        public string Materia { get; set; }
        public bool Ativo { get; set; }

        // registro
    }
}
