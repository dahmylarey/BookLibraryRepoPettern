using BookLibraryRepoPetternCore.DataModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryRepoPetternCore
{
    public class Book
    {
       

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        
        public string Author { get; set; }
        public string Genre { get; set; }

        public string Description { get; set; }
        public DateTime PublishDate { get; set; }


        [NotMapped]
        public IFormFile CoverPhoto { get; set; }


        [ForeignKey("AuthorId")]
        public virtual Tbl_Author? AuthorsCollection { get; set; }

        [NotMapped]
        public IEnumerable<Book>? Books { get; set; }

        [NotMapped]
        public ICollection<Book>? Journal { get; set; }
    }
}
