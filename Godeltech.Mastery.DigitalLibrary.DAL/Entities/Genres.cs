using System.Collections.Generic;

namespace Godeltech.Mastery.DigitalLibrary.DAL.Entities
{
    public class Genres
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int SubGenreLevel { get; set; }

        //navigation props
        public virtual Genres Parent { get; set; }
        public virtual ICollection<Books> Books { get; set; } = new List<Books>();
        public virtual ICollection<Genres> Descendants { get; set; } = new List<Genres>();
    }
}
