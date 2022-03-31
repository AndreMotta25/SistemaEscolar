using SistemaEscolar.Entidades.PersonContext;
using SistemaEscolar.Entidades.SchoolContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entidades.Interface
{
    public interface ICriar
    {
        List<Pessoa> Criar(School escola);
    }
}
