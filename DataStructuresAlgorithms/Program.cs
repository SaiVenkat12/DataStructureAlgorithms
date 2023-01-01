using System;
using DataStructuresAlgorithms;

namespace DataStructureAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            
            Console.WriteLine("1.unordered \n2.ordered ");
            int choice= Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
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
                    break;
                    case 2:
                    int[] number = { 77, 11, 49, 0, 222, 84,199 };
                    int[] List = number;
                    Array.Sort(List);
                    foreach (int data in List)
                    {
                        list.Add(data);
                    }
                    Console.WriteLine("Search the word : ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    list.Search(no);
                    break;

            }         
        }
    }
}