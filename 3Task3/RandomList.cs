using System;
using System.Collections.Generic;
using lab3task1_2;
namespace lab3task3
{
    public class RandomList
    {
        const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static Random random = new Random();
        static string[] randomArray = new string[102];
        protected static List<string> randomList = new List<string>();
        public static List<string> GetRandomList()
        {
            for (int i = 0; i <= 101; i++)
            {
                char[] randomletters = { alphabet[random.Next(0 , alphabet.Length)], alphabet[random.Next(0, alphabet.Length)],
                alphabet[random.Next(0, alphabet.Length)], alphabet[random.Next(0, alphabet.Length)] };
                string result = new string(randomletters);
                randomArray[i] = result;
            }
            randomList.AddRange(randomArray);
            return randomList;
        }

        public static List<string> DeleteZ()
        {
            const string z = "Z";
            List<string> uniqueRandomList = new List<string>();
            var hs = new HashSet<string>();
            foreach (string element in RandomList.GetRandomList())
                if (hs.Add(element))
                {
                    uniqueRandomList.Add(element);
                }
            for (int i = 0; i < uniqueRandomList.Count; i++)
            {
                if (uniqueRandomList[i][0].ToString() == z)
                {
                    uniqueRandomList.Remove(uniqueRandomList[i]);
                }
            }
            return uniqueRandomList;
        }
    }
}
