using System;
namespace CowTown
{
    public static class LetterUtils
    {
        private static Dictionary<char, int> difficultyIndex = new Dictionary<char, int>();
        private static Random rand = new Random();

        public static List<char> GiveSevenLetters()
        {
            int lettersAdded = 0;
            int vowelsAdded = 0;
            string vowels = "aeiou";
            List<char> letterList = new List<char>();
            
            while(lettersAdded < 7)
            {
                char randomLetter = Convert.ToChar(rand.Next(65, 91));
                letterList.Add(randomLetter);
                lettersAdded += 1;
            }
            
            return letterList;
        }
    }
}

