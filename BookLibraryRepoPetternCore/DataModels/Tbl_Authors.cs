using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryRepoPetternCore.DataModels
{
    public class Tbl_Authors
    {
        [Key, Column("AuthorId")]
        public int AuthorId { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual Book Books { get; set; }
    }
}
