using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Genre")]
        public virtual long GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public virtual  DateTime ReleaseDate { get; set; }
        public virtual DateTime DateTimeCreated { get; set; }
        public virtual DateTime DateTimeModified { get; set; }
        public virtual long NumberInStock { get; set; }
    }
}