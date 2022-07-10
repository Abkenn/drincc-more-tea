using Drincc.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Drincc.DAL.Data.EntityConfigurations
{
    public class SessionNoteTypeConfiguration : IEntityTypeConfiguration<SessionNote>
    {
        public void Configure(EntityTypeBuilder<SessionNote> sessionNoteBuilder)
        {
            sessionNoteBuilder.ToTable("SessionNotes");

            sessionNoteBuilder.HasKey(nameof(SessionNote.Id));
            sessionNoteBuilder.Property(sn => sn.Quantity).IsRequired();
            sessionNoteBuilder.Property(sn => sn.Note).HasMaxLength(5000);
            sessionNoteBuilder.Property(sn => sn.Date).IsRequired();
            sessionNoteBuilder.Property(sn => sn.Rating);

            sessionNoteBuilder.HasOne(sn => sn.Tea).WithMany(tea => tea.SessionNotes);
        }
    }
}
