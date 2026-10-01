namespace AcademiaDasMaravilhas;

public class Plano
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public List<Matricula>? Matriculas { get; set; }
}
