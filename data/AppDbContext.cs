using CadastroEstudanteApi.models;
using Microsoft.EntityFrameworkCore;

namespace CadastroEstudanteApi.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options): base(options) {}

        public DbSet<Estudante> Estudantes { get; set; }
    }
}