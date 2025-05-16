public class Professor
{
    public string Nome { get; set; }
    public string GrauAcademico { get; set; }

    private List<Disciplina> DisciplinasLecionadas { get; } = new List<Disciplina>();


}