using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class DataStore
    {
        public static BindingList<Book> Books { get; } = new BindingList<Book>();
        public static BindingList<Book> BorrowedBooks { get; } = new BindingList<Book>();
    }
}
    

