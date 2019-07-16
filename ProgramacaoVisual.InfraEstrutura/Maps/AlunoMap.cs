namespace ProgramacaoVisual.InfraEstrutura
{
    using ProgramacaoVisual.Dominio;
    using System.Data.Entity.ModelConfiguration;

    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            ToTable("aluno");
            HasKey(k => new { k.Matricula });

            Property(p => p.Matricula)
                .HasColumnName("matricula")
                .HasMaxLength(20)
                .IsRequired();
            Property(p => p.Nome)
                .HasColumnName("nome")
                .HasMaxLength(20)
                .IsRequired();
            Property(p => p.Celular)
                .HasColumnName("celular")
                .HasMaxLength(20);
            Property(p => p.Nascimento)
                .HasColumnName("nascimento");
        }
    }
}