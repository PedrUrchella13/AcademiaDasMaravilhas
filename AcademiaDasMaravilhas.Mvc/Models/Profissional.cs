namespace AcademiaDasMaravilhas;

public class Profissional
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Especialidade { get; set; } = string.Empty; 
    public string? UserId { get; set; }
    public List<Aula> Aulas { get; set; }
}
