using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement;
public class Category
{
    public Category(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}
