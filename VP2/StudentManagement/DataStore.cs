using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal static class DataStore
    { // Shared BindingList so all forms see the same student list
        public static BindingList<Student> Students { get; } = new BindingList<Student>();
    }
}
    

