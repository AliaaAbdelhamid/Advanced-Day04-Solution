using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.SortedDictionary
{
	internal class StringComparer : IComparer<string>
	{
		public int Compare(string? x, string? y)
		{
			if (x == null && y == null) return 0;
			if (x == null) return 1;  
			if (y == null) return -1;
			return string.Compare(y, x);
		}
	}
}
