using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; } = true;

        public override string ToString() =>
            $"{Title} by {Author} {(Available ? "(Available)" : "(Borrowed)")}";
    }
}
    

