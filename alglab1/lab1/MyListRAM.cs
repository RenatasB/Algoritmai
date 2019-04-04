using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	class MyListRAM : MyList
	{
		private Node firstNode;
		private Node lastNode;
		private Node currentNode;
		public override int Length { get; set; }
		public MyListRAM()
		{
			firstNode = null;
			lastNode = null;
			currentNode = null;
			Length = 0;
		}
		public override int GetCurrent()
		{
			return currentNode.Data;
		}
		public override Node GetNode()
		{
			return currentNode;
		}
		public override void SetCurrent(int data)
		{
			currentNode.Data = data;
		}
		public override void AddData(int data)
		{
			var newNode = new Node(data, null, lastNode);
			if (firstNode != null)
			{
				lastNode.Next = newNode;
				lastNode = newNode;
			}
			else
			{
				firstNode = newNode;
				lastNode = newNode;
			}
			Length++;
		}
		public override int PointToStart()
		{
			currentNode = firstNode;
			return currentNode.Data;
		}
		public override int PointToLast()
		{
			currentNode = lastNode;
			return currentNode.Data;
		}

		public override int Next()
		{
			currentNode = currentNode.Next;
			return currentNode.Data;
		}

		public override bool HasNext()
		{
			return currentNode.Next != null;
		}
		public override int Back()
		{
			currentNode = currentNode.Previous;
			return currentNode.Data;
		}

		public override bool HasBack()
		{
			return currentNode.Previous != null;
		}
		public override bool NotEmpty()
		{
			return currentNode != null;
		}
		public override bool Swap(int a, int b)
		{
			var cur = firstNode;
			bool check = false,
				check2 = false;
			while (cur != null)
			{
				if (!check && cur.Data == a)
				{
					cur.Data = b;
					check = true;
				}
				else if (!check2 && cur.Data == b)
				{
					cur.Data = a;
					check2 = true;
				}
				cur = cur.Next;
			}
			return (check && check2);
		}
		public override void CopyTo(MyListRAM other)
		{
			for (Node d1 = firstNode; d1 != null; d1 = d1.Next)
			{
				other.AddData(d1.Data);
			}
		}

	}
}
