using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			int resultNumber ;
			try
			{
				resultNumber= GetNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private int GetNumber()
		{
			int result = GetInt();
			
			
				if ( result>= 1 &&  result<= 99)
				{
					resultLabel.Text = "符合1-99之間";
				}
				else
				{
					resultLabel.Text = "未符合1-99之間";
				}
			
			return result;
			
		}

		private  int GetInt()
		{
			string input = inputTextBox.Text;
			bool isInt = int.TryParse(input, out int value);
			return isInt ? value : throw new Exception("必須寫數值");
			
		}
	}
}

