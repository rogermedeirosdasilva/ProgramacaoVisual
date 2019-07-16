namespace ProgramcaoVisual.InfraEstrutura
{
    using System.Data.Entity;
    using ProgramacaoVisual.Dominio;
    using ProgramacaoVisual.InfraEstrutura;

    public class Repositorio : DbContext
    {
        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Disciplina> Disciplina { get; set; }

        public Repositorio() : base()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ftec");

            modelBuilder.Configurations.Add(new DisciplinaMap());
            modelBuilder.Configurations.Add(new AlunoMap());
            modelBuilder.Configurations.Add(new AlunoNotaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
