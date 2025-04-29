using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    internal class Acipher : ICipher
    {
        private string textForCode;
        public Acipher()
        {
            textForCode = "";
        }
        public Acipher(string textForCode)
        {
            this.textForCode = textForCode;
        }
        public string TextForCode
        {
            get { return textForCode; }
            set
            {
                if (String.IsNullOrEmpty(TextForCode))
                {
                    throw new ArgumentNullException("text");
                }
                textForCode = value;
            }
        }
        public string encode(string x)
        {
            char[] xChars = x.ToCharArray();
            char[] formated = new char[xChars.Length];
            for (int i = 0; i < xChars.Length; i++)
            {
                formated[i] = (xChars[i] == 'z')?'a':(char)(xChars[i]+1);
                //char p = xChars[i];
                //p++;
                
                //formated[i] = p;

            }
            textForCode = new string(formated);
            return textForCode;
        }

        public string decode(string x)
        {
            char[] xChars = x.ToCharArray();
            char[] formated2 = new char[xChars.Length];
            for(int i = 0; i < xChars.Length; i++)
            {
                //char z = xChars[i];
                //z--;
                //formated2[i] = z;
                formated2[i] = (xChars[i] == 'A') ? 'Z' : (char)(xChars[i] - 1);
            }
            textForCode = new string(formated2);
           
            return textForCode;
        }
    }
}
