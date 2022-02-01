using System;
using System.Linq;

namespace CodeWars
{
    class Program
    { 
    
       static void Main(string[] args)
        {
            string text= "ABCDEFGH i asdkmaksmdkads";
            Console.WriteLine(Kata.AlphabetPosition(text));

        }
    }
    public class Kata
    {
        public static string AlphabetPosition(string text)
        {
            char[] alpha = "_ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] _alpha = "_abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] chartext = text.ToCharArrayx();
            for (int i = 0; i < chartext.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (chartext[i]==alpha[j])
                    {

                        //chartext[i] = ;
                        chartext[i] = Char.ConvertFromUtf32((char)(j + '0'))[0];
                    }


                }
                for (int k = 0; k < _alpha.Length; k++)
                {
                    if (chartext[i] == _alpha[k])
                    {

                       chartext[i] = Char.ConvertFromUtf32((char)(k + '0'))[0];
                    }

                }
                Console.WriteLine(chartext[i]);
            }
            text = new String(chartext);
            return text;
        }

    }

}
    