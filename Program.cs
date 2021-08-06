using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string tempCompare = "find";

            List<string> stringList = new List<string>();
            stringList.Add("findnoO");
            stringList.Add("fslsls");
            string sumChar = "";
            //foreach (char tempChar in tempCompare)
            //{
            //    sumChar = sumChar + tempChar;
            //    //System.Console.WriteLine(sumChar);

            //    foreach (string tempString in stringList)
            //    {
            //        if (tempString.StartsWith(sumChar))
            //        {
            //            Console.WriteLine("match");
            //            Console.WriteLine(sumChar);
            //            Console.WriteLine(tempString);
            //        }
            //        // compare the string


            //    }

            //}



            Console.WriteLine(Result.makingAnagrams("cde", "abcc"));
            Console.WriteLine("Hello World!");
            //Console.WriteLine(Result.makingAnagrams("absdjkvuahdakejfnfauhdsaavasdlkj", "dcfdjfladfhiawasdkjvalskufhafablsdkashlahdfa"));

        }
    }

    class Result
    {

        /*
         * Complete the 'makingAnagrams' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING s1
         *  2. STRING s2
         */

        public static int makingAnagrams(string s1, string s2)
        {
            int numDeletions = 0;
            string s1Copy = s1;
            string s2Copy = s2;

            string chars1Search = "";
            string chars2Search = "";
            foreach (char charIns1 in s1)
            {

                // ignore values already searched/deleted
                if (!chars1Search.Contains(charIns1))
                {


                    // search for charIns1 in s2Copy
                    // if not found d
                    if (!s2Copy.Contains(charIns1))
                    {
                        //System.Console.WriteLine("S1");
                        //System.Console.WriteLine(charIns1);
                        // delete all occurances of charIns1 in s1Copy
                        int length = s1Copy.Length;
                        s1Copy = s1Copy.Replace(charIns1.ToString(), "");
                        numDeletions = numDeletions + length - s1Copy.Length;
                        //System.Console.WriteLine(numDeletions);
                    }
                    else // both strings contain the character
                    {
                        int length1 = s1Copy.Split(charIns1).Length - 1;
                        int lenght2 = s2Copy.Split(charIns1).Length - 1;
                        if (length1 > lenght2)
                        {
                            s1Copy = s1Copy.Replace(charIns1.ToString(), "");
                            for (int i = 0; i < lenght2; i++)
                            {
                                s1Copy += charIns1;
                            }
                            // update number of deletions
                            numDeletions = numDeletions + length1 - lenght2;

                        }
                        else if (lenght2 > length1)
                        {
                            s2Copy = s2Copy.Replace(charIns1.ToString(), "");
                            for (int i = 0; i < length1; i++)
                            {
                                s2Copy += charIns1;

                            }
                            // update number of deletions
                            numDeletions = numDeletions + lenght2 - length1;

                        }

                        // equal string don't do anything

                    }
                }

                chars1Search = chars1Search + charIns1;

            }


            // search the first string for characters in s2
            foreach (char charIns2 in s2)
            {
                // search for character
                if (!s1Copy.Contains(charIns2))
                {
                    // delete all occurance of charIns2 in s2Copy
                    int length = s2Copy.Length;
                    s2Copy = s2Copy.Replace(charIns2.ToString(), "");
                    numDeletions = numDeletions + length - s2Copy.Length;

                }
            }

            return numDeletions;

        }

    }
}
