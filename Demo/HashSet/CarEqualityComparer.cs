using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HashSet
{
	internal class CarEqualityComparer : IEqualityComparer<Car>
	{
		public bool Equals(Car? x, Car? y)
		{
			if (ReferenceEquals(x, y)) return true;

			if (x is null || y is null) return false;

			return x.Code == y.Code && x.Model == y.Model;
		}

		public int GetHashCode([DisallowNull] Car obj)
		{
			return HashCode.Combine(obj.Code, obj.Model);
		}
	}
}
