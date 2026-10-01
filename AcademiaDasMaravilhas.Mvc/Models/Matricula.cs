namespace AcademiaDasMaravilhas;

public class Matricula
{
    public int Id { get; set; }
    public DateTime DataInicio { get; set; }
    public int AlunoId { get; set; }
    public Aluno? Aluno { get; set; }
    public int PlanoId { get; set; }
    public Plano? Plano { get; set; }
}
