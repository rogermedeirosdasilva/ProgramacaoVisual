namespace ProgramacaoVisual.InfraEstrutura
{
    using ProgramacaoVisual.Dominio;
    using System.Data.Entity.ModelConfiguration;

    public class DisciplinaMap : EntityTypeConfiguration<Disciplina>
    {
        public DisciplinaMap()
        {
            ToTable("disciplina");
            HasKey(k => new { k.Codigo });

            Property(p => p.Codigo)
                .HasColumnName("disciplinaid")
                .IsRequired();
            Property(p => p.Descricao)
                .HasColumnName("descricao")
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
