using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
	class MyArrayIO : MyArray
	{
		

		FileStream fs;
		public override int Length { get; set; }
		public MyArrayIO(string filename)
		{
			
			if (File.Exists(filename)) File.Delete(filename);
			File.Create(filename).Close();

			fs = new FileStream(filename, FileMode.Open,
FileAccess.ReadWrite);
		}
		 public override int this[int index]
		{
			get
			{
				Byte[] data = new Byte[4];
				fs.Seek((4 * index), SeekOrigin.Begin);
				fs.Read(data, 0, 4);
				int result = BitConverter.ToInt32(data, 0);
				return result;
			}
			set
			{
				fs.Seek(4 * index, SeekOrigin.Begin);
				Byte[] data = new Byte[4];
				BitConverter.GetBytes(value).CopyTo(data, 0);
				fs.Write(data, 0, 4);
			}
		}

		public override void Swap(int a, int b)
		{
			Byte[] temp = new Byte[4];
			Byte[] temp2 = new Byte[4];
			fs.Seek(4 * a, SeekOrigin.Begin);
			fs.Read(temp, 0, 4);
			fs.Seek(4 * b, SeekOrigin.Begin);
			fs.Read(temp2, 0, 4);
			fs.Write(temp, 0, 4);
			fs.Seek(4 * a, SeekOrigin.Begin);
			fs.Write(temp2, 0, 4);
		}

		public override void CopyTo(MyArray data, int v)
		{
			throw new NotImplementedException();
		}
		public void Close()
		{
			fs.Close();
		}
	}
}
