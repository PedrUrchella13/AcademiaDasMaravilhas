namespace Academia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AcademiaDasMaravilhas.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AcademiaDasMaravilhas;

[Authorize(Roles = "Admin,Colaborador")]
    public class AlunosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlunosController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index() =>
            View(await _context.Alunos.ToListAsync());

        // Create, Edit, Delete seguem o mesmo padrão de CRUD que já vimos na aula anterior (Produto/Categoria)
    }

