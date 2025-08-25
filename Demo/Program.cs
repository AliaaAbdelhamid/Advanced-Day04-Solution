using Demo.HashTable;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Non Generic - HashTable 

			//Hashtable hashtable = new Hashtable(new StringEqualityComparer())
			//{
			//	["Mona"] = 111,
			//	["Salma"] = 222,
			//	["Amr"] = 333
			//};


			#region Custom Equality Comparer

			//hashtable.Add("mona", 1000); // ArgumentException


			//foreach (var item in hashtable)
			//	Console.WriteLine(item);

			#endregion

			#region Iteration on HashTable 

			//foreach (DictionaryEntry item in hashtable)
			//	Console.WriteLine($"Person Name = {item.Key} , Number = {item.Value}");
			//// Person Name = Mona , Number = 111
			//// Person Name = Salma , Number = 222
			//// Person Name = Amr , Number = 333

			//foreach (string item in hashtable.Keys)
			//	Console.WriteLine(item);
			//// Mona
			//// Amr
			//// Salma

			//foreach (int item in hashtable.Values)
			//	Console.WriteLine(item);
			////  111
			////  222
			////  333

			#endregion

			#region Indexer 

			//// Using Indexer To get Value 
			//Console.WriteLine(hashtable["Mona"]); // 111

			//// Using Indexer To Set Value 
			//hashtable["Mona"] = 999;
			//Console.WriteLine(hashtable["Mona"]); // 999

			//// Using Indexer To Add Element  
			//hashtable["Maryam"] = 1000;

			//for (int i = 0; i < hashtable.Count; i++)
			//	Console.WriteLine(hashtable[i]); // NULL Key Is Not Found 

			#endregion

			#region Adding New Elements 

			//hashtable.Add("Mona", 500); // ArgumentException -> Unsafe Code 

			//// Safe Way 
			//if (!hashtable.ContainsKey("Mona"))
			//	hashtable.Add("Mona", 500); // ArgumentException -> Unsafe Code 

			#endregion


			#endregion

		}
	}
}
