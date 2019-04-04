using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	class MyListIO : MyList
	{
		FileStream fs;

		private int firstNode;
		private int lastNode;
		private int currentNode;
		int nextNode;
		int prevNode;
		public MyListIO(string filename)
		{
			if (File.Exists(filename)) File.Delete(filename);
			File.Create(filename).Close();

			fs = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);

			//fs.Write

			firstNode = 0;
			lastNode = 0;
			currentNode = 0;
			nextNode = 0;			prevNode = 0;

		}


		public override int Length { get; set; }

		public override void AddData(int data)
		{
			throw new NotImplementedException();
		}

		public override int Back()
		{
			throw new NotImplementedException();
		}

		public override void CopyTo(MyListRAM other)
		{
			throw new NotImplementedException();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetCurrent()
		{
			throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override Node GetNode()
		{
			throw new NotImplementedException();
		}

		public override bool HasBack()
		{
			throw new NotImplementedException();
		}

		public override bool HasNext()
		{
			throw new NotImplementedException();
		}

		public override int Next()
		{
			Byte[] data = new Byte[8];
			fs.Seek(nextNode, SeekOrigin.Begin);
			fs.Read(data, 0, 8);
			prevNode = currentNode;
			currentNode = nextNode;
			int result = BitConverter.ToInt32(data, 0);
			nextNode = BitConverter.ToInt32(data, 4);
			return result;
		}

		public override bool NotEmpty()
		{
			throw new NotImplementedException();
		}

		public override int PointToLast()
		{
			throw new NotImplementedException();
		}

		public override int PointToStart()
		{
			Byte[] data = new Byte[8];
			fs.Seek(0, SeekOrigin.Begin);
			fs.Read(data, 0, 4);
			currentNode = BitConverter.ToInt32(data, 0);
			prevNode = -1;
			fs.Seek(currentNode, SeekOrigin.Begin);
			fs.Read(data, 0, 8);
			int result = BitConverter.ToInt32(data, 0);
			nextNode = BitConverter.ToInt32(data, 4);
			return result;
		}

		public override void SetCurrent(int data)
		{
			throw new NotImplementedException();
		}

		public override bool Swap(int a, int b)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
