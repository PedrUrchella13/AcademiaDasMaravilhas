namespace AcademiaDasMaravilhas;

public class Inscricao
{
    public int Id { get; set; }
    public DateTime DataInscricao { get; set; }
    public Aluno? Aluno { get; set; }
    public int AulaId { get; set; }
    public Aula? Aula { get; set; }
}
