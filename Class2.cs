using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguyenvantan_buoi9
{
    internal class Class2
    {
    }
    class MyClass : IIfc1
    {
        public string printOut(string s)
        {
            MessageBox.Show(s);
            return s;
        }
    }
}

