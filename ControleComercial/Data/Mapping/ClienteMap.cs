using ControleComercial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleComercial.Data.Mapps
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(c => c.ID);

            builder.Property(c => c.NomeCliente)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(c => c.Endereco)
                .HasMaxLength(255);

            builder.Property(c => c.Telefone)
                .HasMaxLength(15);

            builder.Property(c => c.Email)
                .HasMaxLength(100);

            builder.Property(c => c.DataCadastro)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
