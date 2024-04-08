﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        IEnumerable<Book> Books { get; set; }


        public ICollection<Book> books { get; set; }
    }
}