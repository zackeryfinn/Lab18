using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab18
{
	// James -- I like that this is all in it's own file.
	public static class LinkedListExtensions
	{
		public static bool RemoveAt<t>(this LinkedList<t> list, int index)
		{
			index = index - 1;
			LinkedListNode<t> currentNode = list.First;
			for (int i = 0; i <= index && currentNode != null; i++)
			{
				if (i != index)
				{
					currentNode = currentNode.Next;
					continue;
				}
				list.Remove(currentNode);
			}
			return false;
		}

		public static void PrintReverse<t>(this LinkedList<t> list)
		{
			for (int i = list.Count - 1; i >= 0; i--)
			{
				Console.WriteLine(list.ElementAt(i));
			}
		}

		public static bool InsertAt<t>(this LinkedList<t> list, int index, t o)
		{
			index = index - 1;
			LinkedListNode<t> currentNode = list.First;
			for (int i = 0; i <= index && currentNode != null; i++)
			{
				if (i != index)
				{
					currentNode = currentNode.Next;
					continue;
				}

				list.AddAfter(currentNode, o);

			}

			return false;
		}

		public static void WriteOut<t>(this LinkedList<t> list)
		{
			foreach (var node in list)
			{
				Console.WriteLine(node);
			}
		}



	}
}
