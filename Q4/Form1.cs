using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			try
			{ 
				resultLabel.Text= $"以人頭計算價格:{GetPeoplePrice(60)}以車數計算價格:{GetCarPrice(200)}";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private int GetPeoplePrice(int onePersonPrice)
		{
			int totalPeople = GetCalculablePeople();
			int peoplePrice = onePersonPrice * totalPeople;
			return peoplePrice;
		}
		private int GetCarPrice(int oneCarPrice)
		{
			int totalCar = GetCalulableCar();
			int carPrice = oneCarPrice * totalCar;
			return carPrice;
		}
		private int GetCalculablePeople()
		{
			string peopleAmount = peopleTextBox.Text;
			bool isInt = int.TryParse(peopleAmount, out int calculablePeopleNumber);
			return isInt ? calculablePeopleNumber : throw new Exception("數量格式有誤");
		}
		private int GetCalulableCar()
		{
			string carAmount=carTextBox.Text;
			bool isInt=int.TryParse(carAmount, out int calculableCarNumber);
			return isInt ? calculableCarNumber : throw new Exception("數量格式有誤");
		}
	}
}
