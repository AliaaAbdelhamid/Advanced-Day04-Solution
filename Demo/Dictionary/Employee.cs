using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Dictionary
{
	internal class Employee : IComparable<Employee>
	{
		public int CompareTo(Employee? other)
		{
			if (other is null) return 1;
			return Id.CompareTo(other.Id);
		}

		public override bool Equals(object? obj)
		{
			return obj is Employee employee &&
				   Id == employee.Id &&
				   Name == employee.Name &&
				   Salary == employee.Salary;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Name, Salary);
		}

		public Employee(int id, string? name, decimal salary)
		{
			Id = id;
			Name = name;
			Salary = salary;
		}

		public int Id { get; set; }
		public string? Name { get; set; }
		public decimal Salary { get; set; }

		public override string? ToString()
		{
			return $"Id = {Id} , name = {Name} , Salary = {Salary}";
		}
	}
}
