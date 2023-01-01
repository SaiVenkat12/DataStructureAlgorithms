using System;
using DataStructuresAlgorithms;

namespace DataStructureAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericLinkedList<string> words = new GenericLinkedList<string>();
            string sentence = "If you look at what you don't have in life, you'll never have enough";
            string[] arr = sentence.Split(" ");

            foreach (string data in arr)
            {
                words.Add(data);
            }
            Console.WriteLine("Search the word : ");
            string word = Console.ReadLine();
            words.Search(word);
            words.Display();
        }
    }
}