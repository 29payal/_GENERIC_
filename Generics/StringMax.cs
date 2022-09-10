using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StringMax
    {
        public string PrintMaximumString(string name1, string name2, string name3)
        {
            if (name1.CompareTo(name2) > 0 && name1.CompareTo(name3) > 0
                || name1.CompareTo(name2) >= 0 && name1.CompareTo(name3) > 0
                || name1.CompareTo(name2) > 0 && name1.CompareTo(name3) >= 0)
            {
                return name1;
            }
            if (name2.CompareTo(name1) > 0 && name2.CompareTo(name3) > 0
                 || name2.CompareTo(name1) >= 0 && name2.CompareTo(name3) > 0
                 || name2.CompareTo(name1) > 0 && name2.CompareTo(name3) >= 0)
            {
                return name2;
            }
            if (name3.CompareTo(name1) > 0 && name3.CompareTo(name2) > 0
                || name3.CompareTo(name1) >= 0 && name3.CompareTo(name2) > 0
                || name3.CompareTo(name1) > 0 && name3.CompareTo(name2) >= 0)
            {
                return name3;
            }
            return name1;

        }
    }
}
   