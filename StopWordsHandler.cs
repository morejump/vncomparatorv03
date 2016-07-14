using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vnComparatorV03
{
    /// <summary>
    /// TODO: generally stop word are removed to make the indexing process effective, We can consider the term as stop words which has highest 
    /// term frequency on document corpus.
    /// </summary>
    class StopWordsHandler
    {
        public static string relativePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        //you can defined other stop word list here
        public static string[] stopWordsList = System.IO.File.ReadAllLines(relativePath + "\\vnStop-words.txt");

        public static Boolean IsStotpWord(string word)
        {
            if (stopWordsList.Contains(word))
                return true;
            else
                return false;
        }
    }
}
