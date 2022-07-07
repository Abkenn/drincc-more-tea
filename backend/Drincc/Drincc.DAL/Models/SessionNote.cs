using Microsoft.EntityFrameworkCore;

namespace Drincc.DAL.Models
{
    [Owned]
    public class SessionNote
    {
        public SessionNote(string note)
        {
            Note = note;
        }

        public string Note { get; private set; } = string.Empty;
    }
}
