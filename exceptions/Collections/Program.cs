using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("C#");
            list.Add("java");
            list.Add("javascript");
            list.Add("python");

            foreach (var item in list)
            {
                Console.WriteLine($"{item}\n");
            }

            if (list.Contains("java"))
            {
                list.Remove("java");
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item}\n");
            }

            Zoo myAwesomeZoo = new Zoo();
            foreach (var animal in myAwesomeZoo.Animal)
            {
                Console.WriteLine($"This is a {animal.Name}, and it's a {animal.Gender}");
            }

            Console.WriteLine("\n*****STACK*****");
            Stack<string> myStack = new Stack<string>();
            myStack.Push("C#");
            myStack.Push(".NET");
            myStack.Push("SQL");

            int countS = myStack.Count;

            for (int i = 0; i < countS; i++)
            {
                Console.WriteLine(myStack.Pop());
            }

            Console.WriteLine("\n*****QUEUE*****");
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("C#");
            myQueue.Enqueue(".NET");
            myQueue.Enqueue("SQL");

            int countQ = myQueue.Count;

            for (int i = 0; i < countQ; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.WriteLine("\n*****DICTIONARY*****");
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();//key value pairs;
            //Gigi, 20;
            dict.Add("Gigi", 30.23M);
            dict.Add("Ion", 23.23M);
            dict.Add("Mos Craciun", 0M);

            foreach (var inregistrare in dict)
            {
                Console.WriteLine($"{inregistrare.Key} has {inregistrare.Value} lei.");
            }

            Dictionary<string, List<string>> keyListDictionary = new Dictionary<string, List<string>>();

            List<ILandBound> landAnimal = new List<ILandBound>();










            Console.ReadLine();
        }
    }
}
