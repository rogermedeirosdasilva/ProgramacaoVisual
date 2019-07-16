namespace ProgramacaoVisual.InfraEstrutura
{
    using ProgramacaoVisual.Dominio;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    public class AlunoNotaMap : EntityTypeConfiguration<AlunoNota>
    {
        public AlunoNotaMap()
        {
            HasKey(k => new { k.Codigo });
            ToTable("aluno_nota");

            Property(p => p.Codigo)
                .HasColumnName("notaid")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(p => p.Matricula)
                .HasColumnName("matricula")
                .HasMaxLength(20)
                .IsRequired();
            Property(p => p.CodigoDisciplina)
                .HasColumnName("disciplinaid")
                .IsRequired();
            Property(p => p.Avaliacao)
                .HasColumnName("avaliacao")
                .IsRequired();
        }
    }
}