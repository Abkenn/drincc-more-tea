namespace Drincc.DAL.Models
{
    public class Tea
    {
        public long Id { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public string Description { get; private set; } = string.Empty;

        public string VendorName { get; private set; } = string.Empty;

        private string? _brandName;
        public string? BrandName
        {
            get => _brandName ?? VendorName;
            private set => _brandName = value ?? VendorName;
        }

        public string? YearOfProduction { get; private set; } = string.Empty;

        private DateTime dateBought;
        public DateTime DateBought
        {
            get => dateBought;
            set => dateBought = value.Date;
        }

        // owned entities
        public PriceDetails? PriceDetails { get; private set; }

        private readonly List<SessionNote> _sessionNotes = new();
        public IReadOnlyCollection<SessionNote> SessionNotes => _sessionNotes.AsReadOnly();


        private Tea() { }

        public Tea(string name, string vendorName, string? yearOfProduction = null, string? brandName = null, DateTime? dateBought = null)
        {
            Name = name;
            VendorName = vendorName;
            BrandName = brandName ?? vendorName;
            YearOfProduction = yearOfProduction ?? string.Empty;
            DateBought = dateBought ?? DateTime.UtcNow.Date;
        }

        public void UpdateTeaDetails(string? name = null, string? vendorName = null, string? brandName = null)
        {
            if (name == null && vendorName == null && brandName == null)
            {
                throw new ArgumentNullException();
            }

            Name = name ?? Name;
            VendorName = vendorName ?? VendorName;
            BrandName = brandName ?? vendorName ?? BrandName;
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
