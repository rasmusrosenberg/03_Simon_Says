using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Simon_Says
{
    class Simon

    {
        public String Echo(String input)
        {
            return input.ToLower();
        }

        public String Shout(String input)
        {
            return input.ToUpper();
        }

        public String Repeat(String input, int repeat)
        {

            String builder = "";

            for (int i = 1; i <= repeat; i++)
            {
                builder += input + " ";
            }

            return builder.Trim();

        }

        public String Repeat(String input)
        {
            return input + " " + input;
        }

        public String StartOfWord(String input, int place)
        {
            return input.Substring(0, place);
        }

        public String FirstWord(String input)
        {
            String[] words = input.Split(' ');
            return words[0];
        }

        // Private method
        private String UcFirstLetter(String input)
        {
            String first = input.Substring(0, 1).ToUpper();
            String last  = input.Substring(1);

            return first + last;
        }

        // Private method
        private bool isSmall(String input)
        {

            String[] whitelist = {"and", "over", "the"};

            if (whitelist.Contains(input.ToLower()))
                return true;
            return false;

        }

        public String Titleize(String input)
        {

            String[] words = input.Split(' ');
            String builder = "";

            foreach (String word in words)
            {
                if (isSmall(word))
                    builder += word + " ";
                else
                    builder += UcFirstLetter(word) + " ";
            }

            builder = UcFirstLetter(builder);

            return builder.Trim();

        }


    }

}
