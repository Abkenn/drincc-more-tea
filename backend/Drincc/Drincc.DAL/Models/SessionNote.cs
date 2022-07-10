namespace Drincc.DAL.Models
{
    public class SessionNote
    {
        public SessionNote() { }

        public SessionNote(DateTime date, float quantity, string note, int rating, long teaId, Tea tea)
        {
            Date = date;
            Quantity = quantity;
            Note = note;
            Rating = rating;
            TeaId = tea.Id;
            Tea = tea;
        }

        public long Id { get; private set; }

        public DateTime Date { get; private set; }

        public float Quantity { get; private set; }

        public string Note { get; private set; } = string.Empty;

        public int Rating { get; private set; }

        public long TeaId { get; private set; }

        public Tea? Tea { get; private set; }
    }
}
