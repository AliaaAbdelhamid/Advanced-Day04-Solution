using Demo.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SortedDictionary
{
	internal class EmployeeNameComparer : IComparer<Employee>
	{
		public int Compare(Employee? x, Employee? y)
		{
			if (ReferenceEquals(x, y)) return 0;
			if (x is null) return -1;
			if (y is null) return 1;

			return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
		}
	}
}
