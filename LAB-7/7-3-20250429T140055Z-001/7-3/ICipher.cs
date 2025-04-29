using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    internal interface ICipher
    {
        string encode(string x);
        string decode(string x);
    }
}
