using System.Data.Entity.ModelConfiguration;
using Godeltech.Mastery.DigitalLibrary.DAL.Entities;

namespace Godeltech.Mastery.DigitalLibrary.DAL.EF.Map
{
    internal  class GenresMap : EntityTypeConfiguration<Genres>
    {
        internal GenresMap()
        {
            HasKey(g=>g.GenreId);
            HasIndex(g => new {g.Name}).IsUnique(true);
            Property(g => g.Name).IsRequired().HasMaxLength(200);
            Property(g => g.SubGenreLevel).IsRequired();
            HasOptional(c => c.Parent).WithMany(c => c.Descendants).HasForeignKey(c => c.ParentId);
        }
    }
       
}
