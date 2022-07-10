using Drincc.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Drincc.DAL.Data.EntityConfigurations
{
    public class TeaEntityTypeConfiguration : IEntityTypeConfiguration<Tea>
    {
        public void Configure(EntityTypeBuilder<Tea> teaBuilder)
        {
            teaBuilder.ToTable("Teas");

            teaBuilder.HasKey(nameof(Tea.Id));
            teaBuilder.Property(t => t.Name).HasMaxLength(150).IsRequired();
            teaBuilder.Property(t => t.Type)
                .HasMaxLength(6)
                .IsRequired()
                .HasConversion<string>();
            teaBuilder.Property(t => t.Description).HasMaxLength(300);
            teaBuilder.Property(t => t.VendorName).HasMaxLength(150).IsRequired();
            teaBuilder.Property(t => t.QuantityInGrams).IsRequired();
            teaBuilder.Property(t => t.BrandName).HasMaxLength(150);
            teaBuilder.Property(t => t.YearOfProduction).HasMaxLength(50);
            teaBuilder.Property(t => t.DateBought).IsRequired();
            teaBuilder.Property(t => t.PlaceOfOrigin).HasMaxLength(150);
            teaBuilder.Property(t => t.Cultivar).HasMaxLength(50);
            teaBuilder.Property(t => t.Roast).HasMaxLength(50);
            teaBuilder.Property(t => t.Oxidation).HasMaxLength(50);
            teaBuilder.Property(t => t.Rating).HasMaxLength(50);
            teaBuilder.Property(t => t.NumberOfReviews);
            teaBuilder.Property(t => t.MyRating);
            teaBuilder.Ignore(nameof(Tea.MyAverageRating));
            teaBuilder.Property(t => t.NumberOfReviews);

            teaBuilder.OwnsOne<PriceDetails>(nameof(Tea.PriceDetails), priceDetailsBuilder =>
            {
                priceDetailsBuilder.Property(pd => pd.PricePerGramInUSD).IsRequired().HasColumnName("PricePerGramInUSD");
                priceDetailsBuilder.Property(pd => pd.ShippingPricePerGramInUSD).IsRequired().HasColumnName("ShippingPricePerGramInUSD");
                priceDetailsBuilder.Property(pd => pd.AddedTaxesPerUSD).IsRequired().HasColumnName("AddedTaxesPerUSD");
                priceDetailsBuilder.Property(pd => pd.CurrencyBought)
                .HasMaxLength(3)
                .IsRequired()
                .HasConversion<string>()
                .HasColumnName("CurrencyBought");
                priceDetailsBuilder.Property(pd => pd.UsdТоTwd).IsRequired().HasColumnName("UsdТоTwd");
                priceDetailsBuilder.Property(pd => pd.UsdТоJpy).IsRequired().HasColumnName("UsdТоJpy");
                priceDetailsBuilder.Property(pd => pd.UsdТоGbp).IsRequired().HasColumnName("UsdТоGbp");
                priceDetailsBuilder.Property(pd => pd.UsdТоEur).IsRequired().HasColumnName("UsdТоEur");
                priceDetailsBuilder.Property(pd => pd.UsdТоCny).IsRequired().HasColumnName("UsdТоCny");
                priceDetailsBuilder.Property(pd => pd.UsdТоBgn).IsRequired().HasColumnName("UsdТоBgn");
                priceDetailsBuilder.Property(pd => pd.TwdТоJpy).IsRequired().HasColumnName("TwdТоJpy");
                priceDetailsBuilder.Property(pd => pd.TwdТоGbp).IsRequired().HasColumnName("TwdТоGbp");
                priceDetailsBuilder.Property(pd => pd.TwdТоEur).IsRequired().HasColumnName("TwdТоEur");
                priceDetailsBuilder.Property(pd => pd.TwdТоCny).IsRequired().HasColumnName("TwdТоCny");
                priceDetailsBuilder.Property(pd => pd.TwdТоBgn).IsRequired().HasColumnName("TwdТоBgn");
                priceDetailsBuilder.Property(pd => pd.JpyТоGbp).IsRequired().HasColumnName("JpyТоGbp");
                priceDetailsBuilder.Property(pd => pd.JpyТоEur).IsRequired().HasColumnName("JpyТоEur");
                priceDetailsBuilder.Property(pd => pd.JpyТоCny).IsRequired().HasColumnName("JpyТоCny");
                priceDetailsBuilder.Property(pd => pd.JpyТоBgn).IsRequired().HasColumnName("JpyТоBgn");
                priceDetailsBuilder.Property(pd => pd.GbpТоEur).IsRequired().HasColumnName("GbpТоEur");
                priceDetailsBuilder.Property(pd => pd.GbpТоCny).IsRequired().HasColumnName("GbpТоCny");
                priceDetailsBuilder.Property(pd => pd.GbpТоBgn).IsRequired().HasColumnName("GbpТоBgn");
                priceDetailsBuilder.Property(pd => pd.EurТоCny).IsRequired().HasColumnName("EurТоCny");
                priceDetailsBuilder.Property(pd => pd.EurТоBgn).IsRequired().HasColumnName("EurТоBgn");
                priceDetailsBuilder.Property(pd => pd.CnyТоBgn).IsRequired().HasColumnName("CnyТоBgn");
            });

            teaBuilder.Navigation(nameof(Tea.SessionNotes)).UsePropertyAccessMode(PropertyAccessMode.Field);
            //teaBuilder.HasMany(t => t.SessionNotes).WithOne(sn => sn.Tea);
        }
    }
}
