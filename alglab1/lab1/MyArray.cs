using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	abstract class MyArray
	{
		public abstract int Length { get; set; } 
		public abstract int this[int index] { get; set; }
		public abstract void Swap(int x,int y);
		public abstract void CopyTo(MyArray data, int v);

	}
}
