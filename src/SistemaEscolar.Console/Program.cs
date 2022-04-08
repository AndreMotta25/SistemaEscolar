using SistemaEscolar.Entidades.PersonContext;
using SistemaEscolar.Entidades.SchoolContext;
using SistemaEscolar.Entidades.PersonContext.EnumContext;


Professor professor1 = new(1, "Andre", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Masculino, "183.555.789-45", "Programacao", true);
Professor professor2 = new(2, "Angela", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Feminino, "123.545.119-56", "Matematica", true);
Professor professor3 = new(3, "Livia", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Feminino, "155.123.563-12", "Artes", true);
Professor professor4 = new(4, "Thiago", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Masculino, "154.543.176-43", "Fisica", true);
Professor professor5 = new(5, "Enzo", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Masculino, "656.123.765.66", "Portugues", false);

Aluno aluno1 = new(1, "Bernado", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Masculino, "533.209.090-02");
Aluno aluno2 = new(2, "Bruno", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Masculino, "579.001.640-57");
Aluno aluno3 = new(3, "Josenil", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Masculino, "873.184.070-15");
Aluno aluno4 = new(4, "Caleb ", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Masculino, "818.384.468-50");
Aluno aluno5 = new(5, "Regina", SistemaEscolar.Entidades.PersonContext.EnumContext.Enum.Feminino, "889.775.545-35");



School EscolaPrincipal = new(1, "Jose mauro", new Diretor("Andre"));

#region Adicionando professores
EscolaPrincipal.AdicionarProfessor(professor1);
EscolaPrincipal.AdicionarProfessor(professor2);
EscolaPrincipal.AdicionarProfessor(professor3);
EscolaPrincipal.AdicionarProfessor(professor4);
#endregion


# region Criando e adicionando alunos a escola

var alunos = new List<Aluno>() {
    aluno1,
    aluno2,
    aluno3,
    aluno4,
    aluno5
};
EscolaPrincipal.AdicionarAlunos(alunos);

# endregion

EscolaPrincipal.ListarAlunos();
EscolaPrincipal.IniciarTurma(1, "AC4", professor3);
//EscolaPrincipal.AdicionarAlunosTurma("AC4");


//var turma = EscolaPrincipal.RetornarTurma("AC4");
//turma.ListarAlunos();

//EscolaPrincipal.ListarTurmas();


var turma = EscolaPrincipal.RetornarTurma("AC4");
turma.AdicionarAlunosTurma();
//turma.FecharTurma();
turma.InfoTurma();
