using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	abstract class MyList
	{

		public abstract int Length { get; set; }
		public abstract int GetCurrent();
		public abstract Node GetNode();
		public abstract void SetCurrent(int data);
		public abstract void AddData(int data);
		public abstract int PointToStart();
		public abstract int PointToLast();
		public abstract int Next();
		public abstract bool HasNext();
		public abstract int Back();
		public abstract bool HasBack();
		public abstract bool NotEmpty();
		public abstract bool Swap(int a, int b);
		public abstract void CopyTo(MyListRAM other);
	}
	class Node
	{
		public int Data;// { get; set; }
		public Node Next { get; set; }
		public Node Previous { get; set; }
		public Node() { }
		public Node(int data, Node next, Node previous)
		{
			Data = data;
			Next = next;
			Previous = previous;
		}
	}
}
