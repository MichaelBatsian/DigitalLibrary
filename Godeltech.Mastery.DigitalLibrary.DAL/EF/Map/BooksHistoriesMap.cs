using System.Data.Entity.ModelConfiguration;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.EF.Map
{
    internal class BooksHistoriesMap : EntityTypeConfiguration<BooksHistories>
    {
        internal BooksHistoriesMap()
        {
            HasKey(bh => bh.BookHistoryId);
            HasIndex(bc => new {bc.UserId, bc.BookCardId}).IsUnique(true);
            Property(bh => bh.IssueDate).IsRequired();
            Property(bh => bh.ReturningDate).IsRequired();
            HasRequired(bh => bh.Users).WithMany(u => u.BooksHistories).HasForeignKey(bh => bh.UserId);
            HasRequired(bh => bh.BooksCards).WithMany(bc => bc.BooksHistories).HasForeignKey(bh => bh.BookCardId);

        }
    }
}
