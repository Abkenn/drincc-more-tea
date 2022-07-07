using Microsoft.EntityFrameworkCore;

namespace Drincc.DAL.Models
{
    [Owned]
    public class SessionNote
    {
        public SessionNote(string note, int rating)
        {
            Note = note;
            Rating = rating;
        }

        public string Note { get; private set; } = string.Empty;

        public int Rating { get; private set; }
    }
}
