namespace String_ToChar_Remove_etc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // test string
            string myDoc = "1234-abc-5678-def-g9h0";


            PrintTwoFisrtBloks(myDoc); // #0 print two first bloks of numbers 
            ReplaceBloksOfChars(myDoc); // #1 replace two first bloks of letters with *** 
            isContainString(myDoc); // #4 does string contains the given characters "abc" (ignore case)
            IsFirstCharactersMatched(myDoc); // #5 check if a string starts with a given character "555"
            IsLastCharectersMatched(myDoc); // #6 check the last 4 characters of a string are matched to "1a2b"
            



            // #0 print two first bloks of numbers
            static void PrintTwoFisrtBloks(string myDoc)
            {
                string result = myDoc.Split('-')[0] + " " + myDoc.Split('-')[2];
                Console.Write(result);

            }


            // #1 replace two first bloks of letters with *** 
            static void ReplaceBloksOfChars(string myDoc)
            {
                string[] result = myDoc.Split('-');

                for (int i = 0; i < result.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        result[i] = "***";
                    }

                }
                Console.WriteLine("\nThe ID efter mutation is: {0}\n", string.Join("-", result));


                /* An example of ineffective problem solving

                myDoc = "1234-abc-5678-def-g9h0";
                myDoc = myDoc.Replace("abc", "***").Replace("def", "***");
                Console.WriteLine("The final string: '{0}'", myDoc);

                 */

            }


            // #4 does string contains the given characters "abc" (ignore case)
            static void isContainString(string myDoc)
            {
                String value = "ABC";
                StringComparison comp = StringComparison.OrdinalIgnoreCase;
                Boolean result = myDoc.Contains(value, comp);
                Console.WriteLine($"Does string contain specified substring? {result}");

            }


            // #5 check if a string starts with a given character "555"
            static void IsFirstCharactersMatched(string myDoc)
            {
                if (myDoc.StartsWith("555"))
                {
                    Console.WriteLine("First characters are matched");
                }
                else
                {
                    Console.WriteLine("First characters are not matched");
                }

            }


            // #6 check the last 4 characters of a string are matched to "1a2b"
            static void IsLastCharectersMatched(string myDoc)
            {
                if (myDoc.EndsWith("1a2b"))
                {
                    Console.WriteLine("Last characters are matched");
                }
                else
                {
                    Console.WriteLine("Last characters are not matched");
                }

            }
        }
    }
}

           
               