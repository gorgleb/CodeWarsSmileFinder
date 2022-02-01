using System;
using System.Linq;

namespace CodeWars
{
    class Program
    { 
    
       static void Main(string[] args)
        {
            string[] smileys = new string[] { ";", ")", ";*", ":$", "8-D" };
            Console.WriteLine(Kata.CountSmileys(smileys));

        }
            
        
    }
    public static class Kata
    { 
//Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

//Rules for a smiling face:

//Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
//A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
//Every smiling face must have a smiling mouth that should be marked with either ) or D
//No additional characters are allowed except for those mentioned.

//Valid smiley face examples: :) :D ;-D :~)
//Invalid smiley faces: ;( :> :} :]
        public static int CountSmileys(string[] smileys)
        {
            int counter = 0;
            char[] temparray = new char[] { };
            for (int i = 0; i < smileys.Length; i++)
            {

                temparray = smileys[i].ToCharArray();
                for (int j = 0; j < temparray.Length; j++)
                {
                    if (temparray.Length<2)
                    {
                        break;
                    }
                    if (temparray[j] ==':'|| temparray[j] == ';')
                    {
                        if (temparray[j + 1] == ')' || temparray[j + 1] == 'D')
                        {
                            counter += 1;
                            break;
                        }
                        if (temparray[j+1] == '-' || temparray[j+1] == '~')
                        {
                            if (temparray[j+2] == ')' || temparray[j+2] == 'D')
                            {
                                counter += 1; 
                            }
                        }
                        else
                        {
                            break;
                        }
                        
                    }
                }
                
            }
            return counter;
        }
    }

}
    