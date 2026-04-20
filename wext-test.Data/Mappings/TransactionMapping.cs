using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wex_test.Domain;

namespace wext_test.Data.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<TransactionWex>
    {
        public void Configure(EntityTypeBuilder<TransactionWex> builder)
        {

            builder.HasKey(c => c.TransactionID);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(c => c.TransactionDate)
                .IsRequired();


            builder.Property(c => c.PurchaseAmount)
                .IsRequired();

            builder.Property(c => c.PurchaseAmountConverted)
                .IsRequired();

            builder.Property(c => c.ExchangeRate)
              .IsRequired();

            builder.Property(c => c.CountryCurrencyDescription);
             


        }

    }
}
