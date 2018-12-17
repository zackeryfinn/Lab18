using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab18
{

	// James -- not sure about all of these comments, also I would avoid using another students work moving forward.
	class Program
	{
		static void Main(string[] args)
		{
			//creating my array here
			int[] index = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };

			//creating my LinkedList here
			LinkedList<int> linkyList = new LinkedList<int>(index);

			//writing out the elements in my LinkedList
			Console.WriteLine("Here are my Linked List items: ");
			linkyList.WriteOut();
			Console.WriteLine();
			Console.WriteLine("Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();

			//Now I revese the order
			Console.WriteLine("Here are my Linked List items in revese order: ");
			linkyList.PrintReverse();
			Console.WriteLine();
			Console.WriteLine("Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();

			//Now I use the RemoveAt method extension:
			linkyList.RemoveAt(5);
			Console.WriteLine("I removed the 5th element in this list using the RemoveAt method extension: ");
			linkyList.WriteOut();
			Console.WriteLine();
			Console.WriteLine("Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();

			//Now I use the InsertAt method extension:
			Console.WriteLine("I will add the number 299 after the 5th element in this list using the InsertAt method extension: ");
			linkyList.InsertAt(5, 299);
			linkyList.WriteOut();
			Console.WriteLine();
			Console.WriteLine("Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();

			//Now I find the frequency using an array (thanks for the help and inspiration classmates!) and dictionary type
			Console.WriteLine("Frequency counted using an array:");
			ArrayAlgorithm(index);
			Console.WriteLine();
			Console.WriteLine("Press any key to continue... ");
			Console.ReadKey();
			Console.Clear();

			Console.WriteLine("Frequency counted using a dictionary:");
			DictionaryAlgorithm(index);
			Console.WriteLine();
			Console.WriteLine("Press any key to exit... ");
			Console.ReadKey();
			Console.Clear();


		}

		public static void ArrayAlgorithm(int[] index)
		{
			int max = index.Max();

			int[] arrayAlgorithm = new int[max + 1];

			for (int i = 0; i < arrayAlgorithm.Length; i++)
			{
				for (int j = 0; j < index.Length; j++)
				{
					if (index[j] == i)
					{
						arrayAlgorithm[i]++;
					}
				}
			}
			for (int i = 0; i < arrayAlgorithm.Length; i++)
			{
				if (arrayAlgorithm[i] > 0)
				{
					Console.WriteLine($"{{ Number = {i}, Frequency = {arrayAlgorithm[i]} }}");
				}
			}
		}


		public static void DictionaryAlgorithm(int[] index)
		{
			var frequencies = index.GroupBy(n => n)
				.Select(group => new
				{
					Number = group.Key,
					Frequency = group.Count()
				});
			foreach (var item in frequencies)
			{
				Console.WriteLine(item);
			}


		}
	}
}
