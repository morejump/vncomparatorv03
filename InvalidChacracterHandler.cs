using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vnComparatorV03
{
    class InvalidChacracterHandler
    {
        public static string[] invalidCharacter = new string[]{"!","@","#","$","%","^","&","*","(",")","_","-","+","=","~","`","{","[","}","]","|","\\",":",";","\"","'",",","<",">",".","?","/"};

        public static bool isInvalidChar(string s)
        {
            if (invalidCharacter.Contains(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
