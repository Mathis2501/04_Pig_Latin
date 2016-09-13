using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Pig_Latin
{
    class Translator
    {
        public static string Translate(string OrigString)
        {

            string[] n = OrigString.Split(' ');
            string NewString = "";
            bool first = true;
            char[] Vocals = { 'a', 'e', 'i', 'o', 'y' };



            foreach (string element in n)
            {
                if (!first)
                    NewString += " ";

                if (Vocals.Contains(element[0]))
                {
                    NewString += element + "ay";
                }


                else
                {

                    char[] Letters = element.ToCharArray();
                    NewString = OrigString;
                    foreach (char item in Letters)
                    {
                        if (!Vocals.Contains(item))
                        {
                            NewString = NewString.Substring(1);
                            NewString += item.ToString();
                        }

                        else
                        {
                            NewString += element + "ay";
                            break;
                        }







                        /*     string CheckString = element.Substring(element.IndexOf(item));

                         if (Vocals.Contains(CheckString[0]))
                         {
                             NewString += element.Substring(element.IndexOf(item));
                             NewString += element.Substring(0, element.IndexOf(item));
                             NewString += "ay";
                             goto End;
                         }*/


                    }

                    if (first)
                    {
                        first = false;
                    }
                }
            }
            return NewString;

        }
    }
}
