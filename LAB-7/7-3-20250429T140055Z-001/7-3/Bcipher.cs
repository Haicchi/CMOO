using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    internal class Bcipher
    {
        private string textForCode;
        private int key = 3;
        public string encode(string x)
        {
            char[] xChars = x.ToCharArray();
            char[] formated = new char[xChars.Length];
            for (int i = 0; i < xChars.Length; i++)
            {

                //char p = xChars[i];
                //int step = (int)p * 2;
                // var c = 'z' - xChars[i];
                // if (key <= c)
                // {
                //     formated[i] = (char)(xChars[i] + key);
                // }
                // else
                // {
                //     formated[i] = (char)('A' + key - c - 1);
                // }
                //formated[i] = (xChars[i] == 'z') ? 'a' : (char)(xChars[i] - key);

                //formated[i] = p;
                
                formated[i] = (xChars[i] == 'z')?'a':(char)(xChars[i]-(key-1));
                  

            }
            textForCode = new string(formated);
            return textForCode;
        }

        public string decode(string x)
        {
            char[] xChars = x.ToCharArray();
            char[] formated2 = new char[xChars.Length];
            for (int i = 0; i < xChars.Length; i++)
            {
                
               
                formated2[i] = (xChars[i] == 'A') ? 'Z' : (char)(xChars[i] + (key-1));
            }
            textForCode = new string(formated2);

            return textForCode;
        }
    }
}
