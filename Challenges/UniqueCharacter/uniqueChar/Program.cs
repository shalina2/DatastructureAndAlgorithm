using System;

namespace uniqueChar
{
    public class Program
    {
        static bool AreCharactersUnique(string input)
        {
            for (int i = 0; i < input.Length; i++)
                for (int j = 0; j < input.Length; j++)
                    if (input[i] == input[j])
                        return false;
            //if all are unique return true
            return true;
        }
        public static void Main()
        {
            string input = "ILoveCodefellow";
            if (AreCharactersUnique(input) == true)
                Console.WriteLine("The string " + input + " has unique");
            else
                Console.WriteLine("The String " + input + " has duplicate");

        }

    }
}
