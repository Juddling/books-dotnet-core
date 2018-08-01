using System;
using System.Collections.Generic;

namespace dotnet.Database
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string AuthorName { get; set; }
    }
}
