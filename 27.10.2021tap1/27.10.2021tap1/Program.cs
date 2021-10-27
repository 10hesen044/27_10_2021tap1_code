using System;

namespace _27._10._2021tap1
{
    class Program
    {
        static void Main(string[] args)
        {
            FindIndex("salam", 'l');
        }
        static void FindIndex(string word, char character)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == character)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(-1);
            return;
        }
    }
}
