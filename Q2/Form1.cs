using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
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
				GetDateLong();
			}
			catch(Exception ex)
			{
			MessageBox.Show(ex.Message);
			return;
			}
		}
		private void GetDateLong()
		{
			DateTime todayDate = DateTime.Today;
			DateTime compareDate=GetCalculableDate();
			int result=DateTime.Compare(compareDate,todayDate);
			if (result < 1 || result == 0)
			{
				MessageBox.Show("日期不大於今天");
			}
			else 
			{
				MessageBox.Show("日期大於今天");
			}
			
		}
		private DateTime GetCalculableDate()
		{
			string input=inputTextBox.Text;
			bool isDate = DateTime.TryParse(input, out DateTime calculableTime);
			return isDate ? calculableTime : throw new Exception("請輸入正確日期格式");
		}
	}
}
