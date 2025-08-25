using Demo.Dictionary;
using Demo.HashSet;
using Demo.HashTable;
using Demo.SortedDictionary;
using Demo.SortedSet;
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

			#region Generic - SortedDictionary 

			#region Example 01
			//SortedDictionary<string, int> PhoneNote = new SortedDictionary<string, int>(new SortedDictionary.StringComparer())
			//{
			//	["Salma"] = 111,
			//	["Omar"] = 222,
			//	["Rawan"] = 333,
			//	["Yasmin"] = 444,
			//	["Amr"] = 555
			//};

			//foreach (KeyValuePair<string, int> item in PhoneNote)
			//	Console.WriteLine(item);
			//// [Yasmin, 444]
			//// [Salma, 111]
			//// [Rawan, 333]
			//// [Omar, 222]
			//// [Amr, 555] 

			#endregion

			#region Example 02
			//Employee employee01 = new Employee(10, "Omar", 10000);
			//Employee employee02 = new Employee(20, "Salma", 5000);
			//Employee employee03 = new Employee(30, "Ahmed", 9000);

			//SortedDictionary<Employee, string?> SortedEmployees = new(new EmployeeNameComparer())
			//{
			//	[employee02] = "2nd",
			//	[employee03] = "3rd",
			//	[employee01] = "1st",
			//}; 


			//foreach (var item in SortedEmployees)
			//	Console.WriteLine(item);
			//// [Id = 30 , name = Ahmed , Salary = 9000, 3rd]
			//// [Id = 10 , name = Omar , Salary = 10000, 1st]
			//// [Id = 20 , name = Salma , Salary = 5000, 2nd]


			#endregion

			#endregion

			#region Generic - SortedList

			//SortedList<string, int> PhoneBook = new SortedList<string, int>()
			//{
			//	["Salma"] = 111,
			//	["Rawan"] = 333,
			//	["Yasmin"] = 444,
			//	["Omar"] = 222,
			//	["Amr"] = 555
			//};

			//foreach (var phone in PhoneBook)
			//	Console.WriteLine(phone);
			//// [Amr, 555]
			//// [Omar, 222]
			//// [Rawan, 333]
			//// [Salma, 111]
			//// [Yasmin, 444]

			//int value = PhoneBook.GetValueAtIndex(1); 
			//string key = PhoneBook.GetKeyAtIndex(1); 
			//Console.WriteLine("================");
			//Console.WriteLine(value); // 222
			//Console.WriteLine(key); // Omar



			//for (int i = 0; i < PhoneBook.Count; i++)
			//	Console.WriteLine(PhoneBook[i]); // Invalid [string (Key)]

			//int PhoneNumber = PhoneBook["Salma"];
			//Console.WriteLine(PhoneNumber); // 111



			#endregion

			#region Generic - HashSet

			#region Example 01

			//HashSet<string> names = new HashSet<string>();
			//names.Add("Ahmed");
			//names.Add("Omar");
			//names.Add("Yasmin");
			//names.Add("Yasmin");
			//names.Add("ahmed");

			//foreach (string item in names)
			//	Console.WriteLine(item);
			//// Ahmed
			//// Omar
			//// Yasmin
			//// ahmed 

			#endregion

			#region Example 02

			//HashSet<Employee?> Employees = new()
			//{
			//	new Employee(10, "Omar", 10000),
			//	new Employee(20, "Salma", 5000),
			//	new Employee(10, "Omar", 10000),
			//	new Employee(30, "Ahmed", 9000),
			//	new Employee(10, "Omar", 10000),
			//	new Employee(30, "Ahmed", 9000),
			//	new Employee(20, "Salma", 5000),
			//};

			//foreach (Employee? item in Employees)
			//	Console.WriteLine(item);
			////Id = 10 , name = Omar , Salary = 10000
			////Id = 20 , name = Salma , Salary = 5000
			////Id = 30 , name = Ahmed , Salary = 9000

			#endregion

			#region Example 03

			//HashSet<Car> cars = new HashSet<Car>(new CarEqualityComparer());
			//cars.Add(new Car(1, "BMW", 290));
			//cars.Add(new Car(1, "BMW", 190));
			//cars.Add(new Car(1, "BMW", 250));
			//cars.Add(new Car(2, "BYD", 250));
			//cars.Add(new Car(3, "Audi", 290));

			//foreach (Car item in cars)
			//	Console.WriteLine(item);
			//               // 1 :: BMW :: 290
			//               // 2 :: BYD :: 250
			//               // 3 :: Audi :: 290




			//Car[] cars1 =
			//{
			//	new Car(1, "BMW", 290),
			//	new Car(3, "Audi", 290),
			//	new Car(2, "BYD", 250),
			//	new Car(3, "Audi", 290),
			//	new Car(1, "BMW", 290),
			//	new Car(2, "BYD", 250),
			//};


			//cars = new HashSet<Car>(cars1);

			#endregion

			#region Example 04
			//HashSet<int> number01 = new HashSet<int>() { 1, 2, 3, 4, 5 ,11};
			//HashSet<int> number02 = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//bool Result;
			//// Add ITEM to the set, return true if added, false if duplicate
			//   Result = number01.Add(100); // 1 2 3 4 5 100 -  True

			////union with the other
			//number01.UnionWith(number02); // 1 2 3 4 5 11 6 7 8 9 10

			//// its intersection with Other
			//number01.IntersectWith(number02); // 1 2 3 4 5

			//// it contains no elements that are also in other
			//number01.ExceptWith(number02); //11 

			//// it contains elements initially in this or in other, but not both
			//number01.SymmetricExceptWith(number02); // 10 9 8 7 6 11

			//// Check if this set is a subset of other
			//Result = number01.IsSubsetOf(number02); // False Because 11 
			//Console.WriteLine(Result);
			//// True If all elements in the current set exist
			//// True If both sets are equal


			//// Check if this set is a subset of other , but not the same as it
			//Result = number01.IsProperSubsetOf(number02); // False 
			//Console.WriteLine(Result);
			//// True If all elements in the current set exist
			//// False If both sets are equal

			//// Check if this set is a superset of other
			//Result = number01.IsSupersetOf(number02); // False 

			//// Check if this set is a superset of other , but not the same as it
			//Result = number01.IsProperSupersetOf(number02); // False 

			//// Check if this set has any elements in common with other
			//Result = number01.Overlaps(number02); // True 
			//// true if at least one element exists in both sets.
			//// false if no elements are shared.

			//// Check if this set contains the same and only the same elements as other
			//Result = number01.SetEquals(number02); // False
			//// true if the sets have the same elements (order doesn't matter).
			//// false if there's any difference (missing or extra elements).

			//Console.WriteLine("Numbers01");
			//foreach (int item in number01)
			//	Console.Write($"{item} ");
			//Console.WriteLine("\n============================");

			//Console.WriteLine("Numbers02");
			//foreach (int item in number02)
			//	Console.Write($"{item} ");
			#endregion

			#endregion


			#region Generic - SortedSet 

			#region Example 01
			//SortedSet<int> Numbers = new SortedSet<int>(new IntDescComparer()) { 4, 5, 7, 8, 9, 1, 2, 3, 10 };
			//// 10 9 8 7 6 5 4 3 2 1

			////int Max = Numbers.Max(); // 10
			////int Min = Numbers.Min(); // 1

			//var NumbersInRange = Numbers.GetViewBetween(8, 4); // 8 7 6 5 4

			//foreach (int item in Numbers)
			//	Console.Write($"{item} ");
			//Console.WriteLine("\n=================");
			//foreach (int item in NumbersInRange)
			//	Console.Write($"{item} ");

			//if (Numbers.Remove(5))
			//{
			//	Numbers.Add(50);
			//}

			//Console.WriteLine("\nAfter Change ");

			//foreach (int item in Numbers)
			//	Console.Write($"{item} ");
			//Console.WriteLine("\n=================");
			//foreach (int item in NumbersInRange)
			//	Console.Write($"{item} ");


			#endregion

			#region Example 02

			//SortedSet<Car> cars = new SortedSet<Car>(); 
			//cars.Add(new Car(2, "BYD", 250));
			//cars.Add(new Car(1, "BMW", 290));
			//cars.Add(new Car(3, "Audi", 290));
			//cars.Add(new Car(4, "Kia", 290));
			//cars.Add(new Car(5, "Toyota", 290));


			////foreach (var item in cars)
			////	Console.WriteLine(item);
			//// 1 :: BMW :: 290
			//// 2 :: BYD :: 250
			//// 3 :: Audi :: 290
			//// 4 :: Kia :: 290
			//// 5 :: Toyota :: 290

			//Car? Min = cars.Min; // 1 :: BMW :: 290
			//Car? Max = cars.Max; // 3 :: Audi :: 290
			//Console.WriteLine(Min); // 1 :: BMW :: 290
			//Console.WriteLine(Max); // 5 :: Toyota :: 290
			//SortedSet<Car> CarsRange = cars.GetViewBetween(new Car(2, "BYD", 250), new Car(4, "Kia", 290));

			//Console.WriteLine("=======================");
			//foreach (var item in CarsRange)
			//	Console.WriteLine(item);
			//// 2 :: BYD :: 250
			//// 3 :: Audi :: 290
			//// 4 :: Kia :: 290



			#endregion

			#endregion


		}
	}
}
