using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HashTable
{
	internal class StringEqualityComparer : IEqualityComparer
	{
		public new bool Equals(object? x, object? y)
		{
			string? X = x as string;
			string? Y = y as string;
			return string.Equals(X, Y, StringComparison.OrdinalIgnoreCase);
		}

		public int GetHashCode(object obj)
		{
			string? value = obj as string;
			return StringComparer.OrdinalIgnoreCase.GetHashCode(value);
		}
	}
}
