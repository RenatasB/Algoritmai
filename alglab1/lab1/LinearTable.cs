using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	class LinearTable
	{
		private int Count;
		class HashEntry
		{
			private int key;
			private int data;
			public HashEntry(int key, int data)
			{
				this.key = key;
				this.data = data;
			}
			public int GetKey()
			{
				return key;
			}
			public int GetData()
			{
				return data;
			}
		}

		private HashEntry[] table;

		private int maxSize = 0;

		public LinearTable(int size)
		{
			maxSize = size;
			table = new HashEntry[maxSize];
			for (int i = 0; i < maxSize; i++)
			{
				table[i] = null;
			}
		}

		public int Find(int key)
		{
			Count = 0;
			int hash = key % maxSize;
			Count++;
			while (table[hash] != null && table[hash].GetKey() != key)
			{
				hash = (hash + 1) % maxSize;
				Count++;
			}
			Count+=2;
			if (table[hash] == null)
			{
				return -1;
			}
			else
			{
				return Count;
			}
		}

		public void Insert(int key, int data)
		{
			if (!CheckOpenSpace())
			{
				return;
			}
			int hash = (key % maxSize);
			while (table[hash] != null && table[hash].GetKey() != key)
			{
				hash = (hash + 1) % maxSize;
			}
			table[hash] = new HashEntry(key, data);
		}

		private bool CheckOpenSpace()
		{
			bool isOpen = false;
			for (int i = 0; i < maxSize; i++)
			{
				if (table[i] == null)
				{
					isOpen = true;
				}
			}
			return isOpen;
		}

	}
}

