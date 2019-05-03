using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_3._1
{
    class Class1
    {
        static bool AreAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            foreach (char c in s1)
            {
                int ix = s2.IndexOf(c);

                if (ix == -1)
                    return false;
            }

            return true;
        }
    }
}
