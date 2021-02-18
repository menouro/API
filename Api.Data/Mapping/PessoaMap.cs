using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<PessoaEntity>
    {
        public void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {

            builder.ToTable("Pessoa");
            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Email)
                   .IsUnique();

            builder.Property(u => u.Nome)
                   .IsRequired()
                   .HasMaxLength(60);

            builder.Property(u => u.Email)
                   .HasMaxLength(100);

            builder.Property(u => u.Endereço)
                    .IsRequired();

            builder.Property(u => u.Telefone);

            builder.Property(u => u.Estado)
                    .HasMaxLength(2);

            builder.Property(u => u.Cidade);

        }
    }
}
