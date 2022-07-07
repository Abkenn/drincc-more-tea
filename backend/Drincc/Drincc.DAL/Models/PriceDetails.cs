using Drincc.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace Drincc.DAL.Models
{
    [Owned]
    public class PriceDetails
    {
        public PriceDetails(
            decimal pricePerGramInUSD,
            decimal shippingPricePerGramInUSD,
            decimal addedTaxesPerUSD,
            Currency currencyBought,
            decimal usdТоTwd,
            decimal usdТоJpy,
            decimal usdТоGbp,
            decimal usdТоEur,
            decimal usdТоCny,
            decimal usdТоBgn,
            decimal twdТоJpy,
            decimal twdТоGbp,
            decimal twdТоEur,
            decimal twdТоCny,
            decimal twdТоBgn,
            decimal jpyТоGbp,
            decimal jpyТоEur,
            decimal jpyТоCny,
            decimal jpyТоBgn,
            decimal gbpТоEur,
            decimal gbpТоCny,
            decimal gbpТоBgn,
            decimal eurТоCny,
            decimal eurТоBgn,
            decimal cnyТоBgn
            )
        {
            PricePerGramInUSD = pricePerGramInUSD;
            ShippingPricePerGramInUSD = shippingPricePerGramInUSD;
            AddedTaxesPerUSD = addedTaxesPerUSD;
            CurrencyBought = currencyBought;
            UsdТоTwd = usdТоTwd;
            UsdТоJpy = usdТоJpy;
            UsdТоGbp = usdТоGbp;
            UsdТоEur = usdТоEur;
            UsdТоCny = usdТоCny;
            UsdТоBgn = usdТоBgn;
            TwdТоJpy = twdТоJpy;
            TwdТоGbp = twdТоGbp;
            TwdТоEur = twdТоEur;
            TwdТоCny = twdТоCny;
            TwdТоBgn = twdТоBgn;
            JpyТоGbp = jpyТоGbp;
            JpyТоEur = jpyТоEur;
            JpyТоCny = jpyТоCny;
            JpyТоBgn = jpyТоBgn;
            GbpТоEur = gbpТоEur;
            GbpТоCny = gbpТоCny;
            GbpТоBgn = gbpТоBgn;
            EurТоCny = eurТоCny;
            EurТоBgn = eurТоBgn;
            CnyТоBgn = cnyТоBgn;
        }

        public decimal PricePerGramInUSD { get; private set; }


        public decimal ShippingPricePerGramInUSD { get; private set; }

        public decimal AddedTaxesPerUSD { get; private set; }

        public decimal TotalPricePerGramInUSD => (AddedTaxesPerUSD + 1) * (PricePerGramInUSD + ShippingPricePerGramInUSD);

        public Currency CurrencyBought { get; private set; }

        public decimal UsdТоTwd { get; private set; }

        public decimal UsdТоJpy { get; private set; }

        public decimal UsdТоGbp { get; private set; }

        public decimal UsdТоEur { get; private set; }

        public decimal UsdТоCny { get; private set; }

        public decimal UsdТоBgn { get; private set; }

        public decimal TwdТоJpy { get; private set; }

        public decimal TwdТоGbp { get; private set; }

        public decimal TwdТоEur { get; private set; }

        public decimal TwdТоCny { get; private set; }

        public decimal TwdТоBgn { get; private set; }

        public decimal JpyТоGbp { get; private set; }

        public decimal JpyТоEur { get; private set; }

        public decimal JpyТоCny { get; private set; }

        public decimal JpyТоBgn { get; private set; }

        public decimal GbpТоEur { get; private set; }

        public decimal GbpТоCny { get; private set; }

        public decimal GbpТоBgn { get; private set; }

        public decimal EurТоCny { get; private set; }

        public decimal EurТоBgn { get; private set; }

        public decimal CnyТоBgn { get; private set; }
    }
}
