using Demo.Dictionary;
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

			#region Generic - Dictionary  

			#region Example 01
			//Dictionary<string, int> PhoneNote = new Dictionary<string, int>
			//{
			//	{ "Mona", 111 },
			//	{ "Ali", 222 },
			//	{ "Salma", 333 }
			//};


			//KeyValuePair<string, int>[] array =
			//[
			//	new("Mona" , 111),
			//	new("Ahmed" , 222)
			//];

			//PhoneNote = new Dictionary<string, int>(array, new Dictionary.StringEqualityComparer());


			//PhoneNote.Add("mona", 123); // ArgumentException  

			//foreach (var item in PhoneNote)
			//	Console.WriteLine(item);
			//// [Mona, 111]
			//// [Ahmed, 222]


			#region Indexer 

			//// Using Indexer To Set Value 
			//PhoneNote["Mona"] = 100;

			//// Using Indexer To Get Value
			//Console.WriteLine(PhoneNote["Mona"]);
			////Console.WriteLine(PhoneNote["Omar"]); // KeyNotFoundException -> Unsafe 

			//bool Result = PhoneNote.TryGetValue("Omar", out int number);
			//Console.WriteLine(Result);// False
			//Console.WriteLine(number);// 0


			//// Using Indexer To Add New Element 
			//PhoneNote["Omar"] = 1000;  
			//// If Found => Reset
			//// If Not => Add

			#endregion

			#region Add Element 

			//PhoneNote.Add("Mohamed", 1000);
			////PhoneNote.Add("Mohamed", 1000); // ArgumentException

			//// Safe Way 
			//if (!PhoneNote.ContainsKey("Mohamed"))
			//	PhoneNote.Add("Mohamed", 1000);

			//bool Result = PhoneNote.TryAdd("Mohamed", 1000);
			//Console.WriteLine(Result); // False 


			#endregion

			#region Iteration on Dictionary
			//foreach (string item in PhoneNote.Keys)
			//	Console.WriteLine(item);

			//foreach (int item in PhoneNote.Values)
			//	Console.WriteLine(item);

			//foreach (KeyValuePair<string , int> item in PhoneNote)
			//	Console.WriteLine(item);
			//// [Mona, 111]
			//// [Ali, 222]
			//// [Salma, 333] 
			#endregion

			#endregion

			#region Example 02 - Employee

			//Employee employee01 = new Employee(10, "Omar", 10000);
			//Employee employee02 = new Employee(20, "Salma", 5000);
			//Employee employee03 = new Employee(30, "Ahmed", 9000);

			//Dictionary<Employee, string?> employees = new(new EmployeeIdEqualityComparer())
			//{
			//	[employee01] = "1st",
			//	[employee02] = "2nd",
			//	[employee03] = "3rd"
			//};
			//Employee employee04 = new Employee(30, "Salma", 9000);

			//employees.Add(employee04, "4th"); // ArgumentException

			//foreach (var item in employees)
			//	Console.WriteLine(item);
			//// [Id = 10 , name = Omar , Salary = 10000, 1st]
			//// [Id = 20 , name = Salma , Salary = 5000, 2nd]
			//// [Id = 30 , name = Ahmed , Salary = 9000, 3rd]

			#endregion

			#endregion
		}
	}
}
