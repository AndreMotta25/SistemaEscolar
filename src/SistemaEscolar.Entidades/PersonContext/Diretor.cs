using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.PersonContext
{
    public class Diretor
    {
        public Diretor(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
