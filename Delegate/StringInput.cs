using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Inpute(string name);
    public class StringInput
    {
        
        public Inpute GetInpute;

        public void InputeString(string word)
        {
            var wordReplace = Regex.Replace(word, ".{1}", "$0.");
            var wordsplit = wordReplace.Split(Convert.ToChar(".")).ToArray();
            string[] wordarray = new string[] { };
            for (int i = 0; i < wordsplit.Length - 1; i++)
            {
                wordarray[i] = wordsplit[i];
            }
            GetInpute(wordarray.ToString());
        }
    }

    public class StringTwoInpute
    {
        public void InputeStringTwo(string word)
        {

        }


    }
}
