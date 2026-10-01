using Microsoft.AspNetCore.Identity;
namespace AcademiaDasMaravilhas;

public class ApplicationUser : IdentityUser
{
    public string NomeCompleto { get; set; } = string.Empty;
}
