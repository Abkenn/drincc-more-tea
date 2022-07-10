using Drincc.DAL.Enums;

namespace Drincc.DAL.Models
{
    public class Tea
    {
        public long Id { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public TeaCategory Type { get; private set; }

        public string Description { get; private set; } = string.Empty;

        public string VendorName { get; private set; } = string.Empty;

        private string? _brandName;
        public string? BrandName
        {
            get => _brandName ?? VendorName;
            private set => _brandName = value ?? VendorName;
        }

        public float QuantityInGrams { get; private set; }

        public int MyRating { get; private set; }

        private DateTime dateBought;
        public DateTime DateBought
        {
            get => dateBought;
            private set => dateBought = value.Date;
        }

        public string? YearOfProduction { get; private set; } = string.Empty;

        public string? PlaceOfOrigin { get; private set; } = string.Empty;

        public string? Cultivar { get; private set; } = "-";

        public string? Roast { get; private set; } = "-";

        public string? Oxidation { get; private set; } = "-";

        public string? Rating { get; private set; } = "-";

        public int? NumberOfReviews { get; private set; } = 0;


        // owned entities
        public PriceDetails? PriceDetails { get; private set; }

        private readonly List<SessionNote> _sessionNotes = new();
        public IReadOnlyCollection<SessionNote> SessionNotes => _sessionNotes.AsReadOnly();

        // not mapped
        public double? MyAverageRating => _sessionNotes.Count == 0 ? 0 : _sessionNotes.Average(sn => sn.Rating);


        private Tea() { }

        public Tea(
            string name,
            TeaCategory type,
            string description,
            string vendorName,
            float quantityInGrams,
            int myRating,
            string? yearOfProduction = null,
            string? placeOfOrigin = null,
            string? cultivar = null,
            string? roast = null,
            string? oxidation = null,
            string? rating = null,
            int? numberOfReviews = null,
            PriceDetails? priceDetails = null,
            string? brandName = null,
            DateTime? dateBought = null
            )
        {
            Name = name;
            Type = type;
            Description = description;
            VendorName = vendorName;
            BrandName = brandName ?? vendorName ?? VendorName;
            QuantityInGrams = quantityInGrams;
            MyRating = myRating;
            DateBought = dateBought ?? DateTime.UtcNow.Date;
            YearOfProduction = yearOfProduction;
            PlaceOfOrigin = placeOfOrigin;
            Cultivar = cultivar;
            Roast = roast;
            Oxidation = oxidation;
            Rating = rating;
            NumberOfReviews = numberOfReviews;
            if (priceDetails != null)
            {
                UpdatePriceDetails(priceDetails);
            }
        }

        public void UpdateTeaDetails(string? name = null,
            TeaCategory? type = null,
            string? description = null,
            string? vendorName = null,
            float? quantityInGrams = null,
            int? myRating = null,
            DateTime? dateBought = null,
            string? yearOfProduction = null,
            string? placeOfOrigin = null,
            string? cultivar = null,
            string? roast = null,
            string? oxidation = null,
            string? rating = null,
            int? numberOfReviews = null,
            PriceDetails? priceDetails = null,
            string? brandName = null)
        {
            Name = name ?? Name;
            Type = type ?? Type;
            Description = description ?? Description;
            VendorName = vendorName ?? VendorName;
            BrandName = brandName ?? vendorName ?? VendorName;
            QuantityInGrams = quantityInGrams ?? QuantityInGrams;
            MyRating = myRating ?? MyRating;
            DateBought = dateBought ?? DateBought;
            YearOfProduction = yearOfProduction ?? YearOfProduction;
            PlaceOfOrigin = placeOfOrigin ?? PlaceOfOrigin;
            Cultivar = cultivar ?? Cultivar;
            Roast = roast ?? Roast;
            Oxidation = oxidation ?? Oxidation;
            Rating = rating ?? Rating;
            NumberOfReviews = numberOfReviews ?? NumberOfReviews;
            PriceDetails = priceDetails ?? PriceDetails;
            if (priceDetails != null)
            {
                UpdatePriceDetails(priceDetails);
            }
        }

        public void UpdatePriceDetails(PriceDetails priceDetails)
        {
            PriceDetails = priceDetails;
        }

        public void AddSessionNote(SessionNote sessionNote)
        {
            _sessionNotes.Add(sessionNote);
        }

        public void AddSessionNotes(List<SessionNote> sessionNotes)
        {
            _sessionNotes.AddRange(sessionNotes);
        }

        public void RemoveSessionNote(SessionNote sessionNote)
        {
            _sessionNotes.Remove(sessionNote);
        }
    }
}
