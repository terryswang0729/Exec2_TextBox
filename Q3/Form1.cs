using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		private void generateButton_Click(object sender, EventArgs e)
		{
			try 
			{
				GetAgeDiffernce();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
		private void GetAgeDiffernce()
		{
			DateTime today = DateTime.Today;
			int todayYear = today.Year;
		    int inputYear= GetCalculabledate().Year;
			int yearGap=inputYear-todayYear;
			if(yearGap>=13)
			{
				MessageBox.Show("您已滿13歲");
			}
			else
			{
				MessageBox.Show("您未滿13歲");
			}
		}
		private DateTime GetCalculabledate()
		{
			string input=inputTextBox.Text;
			bool isDate=DateTime.TryParse(input, out DateTime calculableDate);
			return isDate ? calculableDate : throw new Exception("請輸入正確日期格式");
		}
	}
}
