using System;


namespace Homework
{
    public class StringArray
    {

        public void CharacterStringOutput(string firstString)
        {
            var chars = firstString.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
                Console.WriteLine(chars[i]);
        }



    }
}
