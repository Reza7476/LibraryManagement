using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_LiybraryManagment;
public class Category
{
    public Category(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}
