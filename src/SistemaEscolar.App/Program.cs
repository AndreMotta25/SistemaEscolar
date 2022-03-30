using SistemaEscolar.Entidades.PersonContext;
using SistemaEscolar.Entidades.SchoolContext;
using SistemaEscolar.Entidades.PersonContext.EnumContext;
using SistemaEscolar.Entidades.MenuContext;
using SistemaEscolar.Entidades.CriadorContext;

School EscolaPrincipal = new(1, "Jose mauro", new Diretor("Andre"));

while (true)
{
    int opt = View.ViewMenu();

    if (opt == 0)
    {
        break;
    }
    else if (opt == 1)
    {
        EscolaPrincipal.Guardar(new CriarProfessor());
    }
    else if (opt == 2)
    {
        EscolaPrincipal.Guardar(new CriarAluno());
    }

    else if (opt == 3)
    {
        // lista os professores
        foreach (var pessoa in EscolaPrincipal.Pessoas)
        {
            if (pessoa is Professor)
                Console.WriteLine(((Professor)pessoa).ToString());
        }
    }
    else if (opt == 4)
    {
        string codigoTurma = View.ViewMontarTurma();

        int idTurma = 0;
        while (true)
        {

        }
    }
}
