using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Dictionary
{
	internal class EmployeeIdEqualityComparer : IEqualityComparer<Employee>
	{
		public bool Equals(Employee? x, Employee? y)
		{
			if (ReferenceEquals(x, y))
				return true;

			if (x is null || y is null)
				return false;

			return x.Id == y.Id;
		}

		public int GetHashCode([DisallowNull] Employee obj)
		{
			return obj.Id.GetHashCode();
		}
	}
}
