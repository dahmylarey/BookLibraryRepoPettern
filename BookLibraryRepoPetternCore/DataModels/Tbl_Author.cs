using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryRepoPetternCore.DataModels
{
    public class Tbl_Author
    {
        [Key, Column("AuthorId")]
        
        public int AuthorId { get; set; }
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Tbl_Author>? AuthorsCollection { get; set; }
       

    }
}
