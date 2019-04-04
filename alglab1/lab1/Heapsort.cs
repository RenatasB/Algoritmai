using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	static class Heapsort
	{

		private static int heapSize;
		public static int OperationCount { get; set; }

		static private void BuildHeap(MyArray arr)
		{
			heapSize = arr.Length - 1; OperationCount++;
			for (int i = heapSize / 2; i >= 0; i--)
			{
				OperationCount++;
				Heapify(arr, i);
			}
		}

		static private void Swap(MyArray arr, int x, int y)
		{
			int temp = arr[x];
			arr[x] = arr[y];
			arr[y] = temp;
			OperationCount += 3;
		}
		
		static private void Heapify(MyArray arr, int index)
		{
			int left = 2 * index;
			int right = 2 * index + 1;
			int largest = index;
			OperationCount += 3;
			if (left <= heapSize && arr[left] > arr[index])
			{
				OperationCount+=2;
				largest = left;
			}

			if (right <= heapSize && arr[right] > arr[largest])
			{
				OperationCount+=2;
				largest = right;
			}

			if (largest != index)
			{
				OperationCount++;
				Swap(arr, index, largest);
				Heapify(arr, largest);
			}
		}

		static public MyArray Sort(MyArray arr)
		{

			OperationCount = 0;

			BuildHeap(arr);
			for (int i = arr.Length - 1; i >= 0; i--)
			{
				Swap(arr, 0, i);
				heapSize--;
				Heapify(arr, 0);
			}
			return arr;
		}

	}













}
