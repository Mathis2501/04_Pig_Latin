using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pig_Latin
{
    class Translator
    {
        public static string Translate(string sentence)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'A', 'E', 'I', 'O' };
            string newSentence = "";
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                char c = char.ToUpper(word[0]);
                bool vowel = "AEIO".IndexOf(c) >= 0;
                if (vowel)
                {
                    newSentence += word + "ay ";
                }
                else
                {
                    char[] letters = word.ToCharArray();
                    string newWord = word;
                    foreach (char letter in letters)
                    {
                        if (vowels.Contains(letter))
                        {
                            newSentence += newWord + "ay ";
                            break;
                        }
                        else
                        {
                            newWord = newWord.Substring(1);
                            newWord += letter.ToString();
                        }
                    }
                }
            }
            newSentence = newSentence.Trim();
            return newSentence;

        }
    }
}
