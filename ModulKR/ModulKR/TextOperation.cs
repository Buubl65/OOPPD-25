using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulKR
{
    internal class TextOperation
    {
        public delegate string TextOperationDelegate(string input);

        public string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public string CountCharacters(string input)
        {
            int countCharacter = 0;

            for(int i = 0; i < input.Length; i++)
            {
                countCharacter++;
            }

            return $"Символів {countCharacter}";
        }

        public string CountWords(string input)
        {
            int wordCount = 0;
            if(input.Trim().Length > 0)
            {
                wordCount = 1;

                for(int i = 0; i < input.Length; i++)
                {
                    if(input[i] == ' ' && i < input.Length && input[i + 1] != ' ')
                    {
                        wordCount++;
                    }
                }
            }
            return $"Слів {wordCount}";
        }
    }
}
