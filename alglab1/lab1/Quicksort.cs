using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	static class Quicksort
	{
		public static int OperationCount;
		private static int MyPartition(MyArray arr, int left, int right)
		{
			int start = left;
			int pivot = arr[start];
			left++;
			right--;
			OperationCount += 4;
			while (true)
			{
				while (left <= right && arr[left] <= pivot)
				{
					left++;
					OperationCount++;
				}


				while (left <= right && arr[right] > pivot)
				{
					right--;
					OperationCount++;
				}

				int temp;

				if (left > right)
				{

					temp = arr[left - 1];
					arr[left - 1] = arr[start];
					arr[start] = temp;
					OperationCount += 3;
					return left;
				}
				temp = arr[left];
				arr[left] = arr[right];
				arr[right] = temp;
				OperationCount += 7;
			}



		}
		public static MyList Sort(MyList arr)
		{
			//MyList arr = new MyList();
			//data.CopyTo(arr);
			//arr = data;
			OperationCount = 0;
			arr.PointToStart();
			Node head = LastNode(arr.GetNode());
			OperationCount += 2;
			QuickSort(arr.GetNode(), head);
			return arr;
		}

		public static MyArray Sort(MyArray arr)
		{
			//MyArray arr = new MyArrayRAM(data.Length);
			//data.CopyTo(arr, 0);

			OperationCount = 0;
			QuickSort(arr, 0, arr.Length);
			return arr;
		}


		static Node LastNode(Node node)
		{
			while (node.Next != null)
			{
				node = node.Next;
				OperationCount++;
			}
			OperationCount++;
			return node;
		}

		private static void QuickSort(MyArray arr, int left, int right)
		{
			if (arr == null || arr.Length <= 1)
				return;
			OperationCount += 2;
			if (left < right)
			{
				int pivot = MyPartition(arr, left, right); OperationCount++;
				QuickSort(arr, left, pivot - 1); OperationCount++;
				QuickSort(arr, pivot, right); OperationCount++;
			}
		}



		static Node Partition(Node l, Node h)
		{
			int pivot = h.Data;
			Node i = l.Previous;
			int temp;
			OperationCount += 3;
			for (Node j = l; j != h; j = j.Next)
			{
				if (j.Data <= pivot)
				{
					if (i != null)
					{
						i = i.Next;
						OperationCount++;
					}
					else
					{
						i = l;
						OperationCount++;
					}



					temp = i.Data;
					i.Data = j.Data;
					j.Data = temp;
					OperationCount+=4;
				}
				OperationCount += 2;
			}
			if (i != null)
			{
				i = i.Next;
				OperationCount++;
			}
			else
			{
				i = l;
				OperationCount++;
			}
			temp = i.Data;
			i.Data = h.Data;
			h.Data = temp;
			OperationCount += 4;
			return i;
		}

		static void QuickSort(Node l, Node h)
		{
			if (h != null && l != h && l != h.Next)
			{
				Node temp = Partition(l, h);OperationCount++;
				QuickSort(l, temp.Previous); OperationCount++;
				QuickSort(temp.Next, h); OperationCount++;
			}
			OperationCount++;
		}

	}
}
