
using System.Data.Entity.ModelConfiguration;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.EF.Map
{
    internal class BooksCardsMap : EntityTypeConfiguration<BooksCards>
    {
        internal BooksCardsMap()
        {
            HasKey(bc => bc.InventoryId);
            Property(bc => bc.Price).IsRequired();
            Property(bc => bc.AuthorString).IsOptional();
            Property(bc => bc.LBC).IsOptional();
            Property(bc => bc.AvailabilityStatus).IsRequired();
            HasRequired(bc => bc.Books).WithMany(b => b.BooksCards).HasForeignKey(bc => bc.BookId);
        }
    }
}
