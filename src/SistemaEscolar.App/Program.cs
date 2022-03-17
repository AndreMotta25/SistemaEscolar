using SistemaEscolar.Entidades.PersonContext;
using SistemaEscolar.Entidades.SchoolContext;
using SistemaEscolar.Entidades.PersonContext.EnumContext;
using SistemaEscolar.Entidades.MenuContext;



School EscolaPrincipal = new(1, "Jose mauro", new Diretor("Andre"));

while (true)
{
    int opt = Menu.ShowMenu();

    if (opt == 0)
    {
        break;
    }
    else if (opt == 1)
    {
        int x = 0;
        while (true)
        {
            Professor professor = Menu.ShowMontarProfessor(x);
            EscolaPrincipal.AdicionarProfessor(professor);

            Console.WriteLine("Deseja continuar ? (S):(N)");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "n")
                break;
            x += 1;

        }
    }
    else if (opt == 2)
    {
        foreach (var professor in EscolaPrincipal.Professores)
        {
            Console.WriteLine(professor.ToString());
        }
    }

}