using CareMIAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CareMIAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ResultadoExame> ResultadoExames { get; set; }
        public DbSet<PlanoSaude> PlanosSaude { get; set; }
        public DbSet<PacientePlanoSaude> PacientesPlanosSaude { get; set; }
        public DbSet<Paciente> Pacientes {  get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Carteirinha> Carteirinhas { get; set; }
        public DbSet<AgendamentoExame> AgendamentoExames { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }


    }
}