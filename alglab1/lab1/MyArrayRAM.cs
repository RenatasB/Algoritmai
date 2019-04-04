using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{

	class MyArrayRAM : MyArray
	{
		private int[] arr;
		public override int Length { get; set; }
		public MyArrayRAM(int size)
		{
			arr = new int[size];
			Length = arr.Length;
		}
		public override int this[int index]
		{
			get { return arr[index]; }
			set { arr[index] = value; }
		}
		public override void Swap(int x,int y)
		{
			int temp = arr[x];
			arr[x] = arr[y];
			arr[y] = temp;
		}
		public override void CopyTo(MyArray other,int index)
		{
			for (int i = 0; i < Length; i++)
			{
				other[index + i] = arr[i];
			}
		}
	}
}
