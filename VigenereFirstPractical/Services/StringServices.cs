using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereFirstPractical.Services
{
    public class StringServices
    {
        public char[] IgnorWhiteSpaces(string str) {

            str = str.Trim();
            str = str.ToLower();

            char[] charArray = str.ToCharArray();
                   
            return charArray;
        }
    }
}
