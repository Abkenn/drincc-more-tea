namespace Drincc.DAL.Models
{
    public class TeaOrder
    {
        public long Id { get; private set; }

        public string VendorName { get; private set; } = string.Empty;

        public DateTime DateBought { get; private set; } = DateTime.UtcNow;
    }
}
