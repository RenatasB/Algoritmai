using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace lab1
{
	public partial class Form1 : Form
	{

		Stopwatch timer = new Stopwatch();
		private MyArray GeneratedArray;
		private MyArray GeneratedArrayD;
		private MyList GeneratedList;
		private MyList GeneratedListD;
		private LinearTable GeneratedTable;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FillListBoxes();
		}

		private void FillListBoxes()
		{
			listBox1.Items.Add("Heap sort");
			listBox1.Items.Add("Quick sort");

			listBox2.Items.Add("RAM");
			listBox2.Items.Add("File");

			listBox3.Items.Add("Array");
			listBox3.Items.Add("List");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			GenerateData(int.Parse(textBox3.Text));
			PrintGeneratedTextBox(textBox1, GeneratedArray);
		}

		private void PrintTextBox(TextBox tb, MyArray text)
		{
			if (checkBox2.Checked)
				return;
			String tbText = "";



			int i = 0;
			int end = int.MaxValue;

			if (checkBox1.Checked)
			{
				i = int.Parse(textBox5.Text);
				end = int.Parse(textBox6.Text);
			}

			for (i = i; i < text.Length && i < end; i++)
			{
				tbText += text[i].ToString() + "\r\n";
			}
			tb.Text = tbText;
		}
		private void PrintGeneratedTextBox(TextBox tb, MyArray text)
		{
			if (checkBox2.Checked)
				return;
			String tbText = "";


			for (int i = 0; i < text.Length; i++)
			{
				tbText += text[i].ToString() + "\r\n";
			}
			tb.Text = tbText;
		}
		private void PrintTextBox(TextBox tb, MyList text)
		{
			if (checkBox2.Checked)
				return;
			String tbText = "";
			for (int i = 0; i < text.Length - 1; i++)
			{
				tbText += text.GetCurrent().ToString() + "\r\n";
				text.Next();
			}
			tb.Text = tbText;
		}
		private void FindElement()
		{
			string[] parts = textBox2.Text.Split('\n');
			bool firstFound = false;
			int count = 0;

			for (int i = 0; i < parts.Length; i++)
			{

				if (firstFound && i != 0 && parts[i] == parts[i - 1])
				{
					count++;
				}
				if (firstFound && i != 0 && parts[i] != parts[i - 1])
				{
					label14.Text = "Count: " + count;
					break;
				}
				if (parts[i] == textBox4.Text + "\r" && !firstFound)
				{
					firstFound = true;
					label11.Text = "Found element: " + textBox4.Text;
					label10.Text = "First found at: " + i.ToString();
					count++;
				}
				if (!firstFound && int.Parse(parts[i].Remove(parts[i].Length - 1)) > int.Parse(textBox4.Text))
				{
					label11.Text = "Found element: " + parts[i];
					label10.Text = "First found at: " + i.ToString();
					count++;
					firstFound = true;
				}
			}

		}
		private void CallSort()
		{
			ButtonControl(false);
			switch (listBox1.SelectedIndex * 100 + listBox2.SelectedIndex * 10 + listBox3.SelectedIndex)
			{
				case 0:
					timer.Restart();
					GeneratedArray = Heapsort.Sort(GeneratedArray);
					timer.Stop();
					PrintTextBox(textBox2, GeneratedArray);
					label7.Text = "Operations:" + Heapsort.OperationCount;
					label8.Text = "Time elapsed:" + timer.ElapsedMilliseconds;
					break;
				case 10:
					timer.Restart();
					GeneratedArrayD = Heapsort.Sort(GeneratedArrayD);
					timer.Stop();
					PrintTextBox(textBox2, GeneratedArrayD);
					label7.Text = "Operations:" + Heapsort.OperationCount;
					label8.Text = "Time elapsed:" + timer.ElapsedMilliseconds;
					break;
				case 100:
					timer.Restart();
					GeneratedArray = Quicksort.Sort(GeneratedArray);
					timer.Stop();
					PrintTextBox(textBox2, GeneratedArray);
					label7.Text = "Operations:" + Quicksort.OperationCount;
					label8.Text = "Time elapsed:" + timer.ElapsedMilliseconds;
					break;
				case 110:
					timer.Restart();
					//PrintTextBox(textBox2, GeneratedArrayD);
					GeneratedArrayD = Quicksort.Sort(GeneratedArrayD);
					timer.Stop();

					PrintTextBox(textBox2, GeneratedArrayD);
					label7.Text = "Operations:" + Quicksort.OperationCount;
					label8.Text = "Time elapsed:" + timer.ElapsedMilliseconds;
					break;
				case 101:
					timer.Restart();
					GeneratedList = Quicksort.Sort(GeneratedList);
					timer.Stop();
					PrintTextBox(textBox2, GeneratedList);
					label7.Text = "Operations:" + Quicksort.OperationCount;
					label8.Text = "Time elapsed:" + timer.ElapsedMilliseconds;
					break;
				case 111:
					timer.Restart();
					GeneratedListD = Quicksort.Sort(GeneratedListD);
					Quicksort.Sort(GeneratedListD);
					PrintTextBox(textBox2, GeneratedListD);
					label7.Text = "Operations:" + Quicksort.OperationCount;
					label8.Text = "Time elapsed:" + timer.ElapsedMilliseconds;
					break;
			}
			ButtonControl(true);
		}

		void ButtonControl( bool enabled)
		{
			button1.Enabled = enabled;
			button2.Enabled = enabled;
			button3.Enabled = enabled;
			button4.Enabled = enabled;
			button5.Enabled = enabled;

		}


		private void GenerateData(int length)
		{
			ButtonControl(false);
			Random rnd = new Random();
			GeneratedArray = new MyArrayRAM(length);
			GeneratedList = new MyListRAM();
			GeneratedTable = new LinearTable(length);
			if (GeneratedArrayD != null)
				(GeneratedArrayD as MyArrayIO).Close();
			GeneratedArrayD = new MyArrayIO("data2.dat");

			GeneratedArrayD.Length = length;

			for (int i = 0; i < length; i++)
			{
				GeneratedArray[i] = rnd.Next(50000);
				GeneratedList.AddData(GeneratedArray[i]);
				GeneratedArrayD[i] = GeneratedArray[i];
				GeneratedTable.Insert(i, GeneratedArray[i]);
			}
			ButtonControl(true);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			CallSort();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			FindElement();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			EvaluateTable();
		}
		private void EvaluateTable()
		{
			Stopwatch twatch = new Stopwatch();
			int totalOperations = 0;
			twatch.Restart();
			for (int i = 0; i < GeneratedArray.Length; i++)
			{
				totalOperations += GeneratedTable.Find(i);
			}
			twatch.Stop();
			label16.Text = "Overall time:" + twatch.ElapsedMilliseconds + "ms";
			label17.Text = "Average time:" + twatch.ElapsedMilliseconds / GeneratedArray.Length + "ms";
			label18.Text = "Overall operations:" + totalOperations;
			label19.Text = "Average operations:" + totalOperations / GeneratedArray.Length;
		}

		private void label16_Click(object sender, EventArgs e)
		{

		}
	}
}
