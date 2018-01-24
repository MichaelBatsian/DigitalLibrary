using System.Data.Entity.ModelConfiguration;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.EF.Map
{
    internal class BooksMap : EntityTypeConfiguration<Books>
    {
        internal BooksMap()
        {
            HasKey(b => b.BookId);
            HasIndex(b => new {b.Name, b.Author, b.Publisher, b.PublishingYear});
            Property(b => b.Name).IsRequired().HasMaxLength(200);
            Property(b => b.Author).IsRequired().HasMaxLength(200);
            Property(b => b.Publisher).IsRequired().HasMaxLength(200);
            Property(b => b.PublishingYear).IsRequired();
            Property(b => b.Image).IsOptional();
            HasRequired(b => b.Genre).WithMany(g => g.Books).HasForeignKey(b => b.GenreId);
        }
    }
}
