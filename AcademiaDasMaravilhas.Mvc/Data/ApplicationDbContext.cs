using Microsoft.EntityFrameworkCore;

namespace AcademiaDasMaravilhas;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base
    (options) {}

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Profissional> Profissionais { get; set; }
    public DbSet<Plano> Planos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<AvaliacaoFisica> AvaliacaoFisicas { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<Inscricao> Inscricoes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
}
