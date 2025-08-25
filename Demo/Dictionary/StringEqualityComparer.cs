using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Dictionary
{
	internal class StringEqualityComparer : IEqualityComparer<string>
	{
		public bool Equals(string? x, string? y)
		{
			return string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
		}

		public int GetHashCode([DisallowNull] string obj)
		{
			return StringComparer.OrdinalIgnoreCase.GetHashCode(obj);
		}
	}
}
