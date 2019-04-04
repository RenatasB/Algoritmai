namespace lab1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 100);
			this.textBox1.MaxLength = 1000000;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(241, 228);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(305, 100);
			this.textBox2.MaxLength = 1000000;
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(239, 228);
			this.textBox2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Sort";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new System.Drawing.Point(206, 29);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 30);
			this.listBox1.TabIndex = 3;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(332, 29);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 30);
			this.listBox2.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(99, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Generated data";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(302, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Sorted data";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(203, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Algorithm";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(329, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Location";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 36);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(81, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "Generate data";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(115, 77);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(85, 20);
			this.textBox3.TabIndex = 11;
			this.textBox3.Text = "1000";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(112, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Data count";
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Location = new System.Drawing.Point(458, 29);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(120, 30);
			this.listBox3.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(455, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Array type";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(582, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Operations: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(582, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Time";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(559, 195);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(85, 20);
			this.textBox4.TabIndex = 17;
			this.textBox4.Text = "1000";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(556, 179);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "Find element";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(559, 221);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(81, 23);
			this.button4.TabIndex = 19;
			this.button4.Text = "Find";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(556, 277);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "First found at:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(556, 259);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 13);
			this.label11.TabIndex = 21;
			this.label11.Text = "Found element:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(559, 65);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(119, 17);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.Text = "Show fragment only";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(559, 133);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(85, 20);
			this.textBox5.TabIndex = 23;
			this.textBox5.Text = "1000";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(659, 133);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(85, 20);
			this.textBox6.TabIndex = 24;
			this.textBox6.Text = "1000";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(647, 136);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(10, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "-";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(556, 117);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(39, 13);
			this.label13.TabIndex = 26;
			this.label13.Text = "Range";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(556, 295);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 13);
			this.label14.TabIndex = 27;
			this.label14.Text = "Count: ";
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(559, 88);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(117, 17);
			this.checkBox2.TabIndex = 28;
			this.checkBox2.Text = "Do not display data";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(99, 36);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(85, 23);
			this.button5.TabIndex = 29;
			this.button5.Text = "Hashtable";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(656, 179);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(55, 13);
			this.label15.TabIndex = 30;
			this.label15.Text = "Hashtable";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(656, 194);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(65, 13);
			this.label16.TabIndex = 31;
			this.label16.Text = "Overall time:";
			this.label16.Click += new System.EventHandler(this.label16_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(656, 208);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(69, 13);
			this.label17.TabIndex = 32;
			this.label17.Text = "Average time";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(656, 222);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(95, 13);
			this.label18.TabIndex = 33;
			this.label18.Text = "Overall operations:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(656, 236);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(102, 13);
			this.label19.TabIndex = 34;
			this.label19.Text = "Average operations:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(808, 340);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
	}
}

