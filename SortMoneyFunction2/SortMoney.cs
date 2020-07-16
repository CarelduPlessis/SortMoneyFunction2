using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortMoneyFunction2
{
    public partial class SortMoney : Form
    {
        public SortMoney()
        {
            InitializeComponent();
        }

        private void btnSortMoney_Click(object sender, EventArgs e)
        {
			// Declaring variable 
			// without assigning value 
			int money1 = 0; // Store results
			int money2 = Convert.ToInt32(EnterValue.Text); // User Input: Total amount of money to be sorted

			// Pass variable i to the method 
			// using out keyword 
			TOSortMoney(money2, out money1, 100); // call function
			tbxMoney100.Text = money1.ToString(); // Display results in textbox
			//money2 = money2 - (money1 * 100); // calculating how much is left of the "User Input" value
			money2 =  LeftOverMoney(money2, money1, 100);

			TOSortMoney(money2, out money1, 50); // call function
			tbxMoney50.Text = money1.ToString(); // Display results in textbox
			//money2 = money2 - (money1 * 50); // calculating how much is left of the "User Input" value
			money2 = LeftOverMoney(money2, money1, 50);

			TOSortMoney(money2, out money1, 20); // call function
			tbxMoney20.Text = money1.ToString(); // Display results in textbox
			//money2 = money2 - (money1 * 20); // calculating how much is left of the "User Input" value
			money2 = LeftOverMoney(money2, money1, 20);

			TOSortMoney(money2, out money1, 10); // call function
			tbxMoney10.Text = money1.ToString(); // Display results in textbox
			//money2 = money2 - (money1 * 10); // calculating how much is left of the "User Input" value
			money2 = LeftOverMoney(money2, money1, 10);

			TOSortMoney(money2, out money1, 5); // call function
			tbxMoney5.Text = money1.ToString();// Display results in textbox
			//money2 = money2 - (money1 * 5); // calculating how much is left of the "User Input" value
			money2 = LeftOverMoney(money2, money1, 5);

			TOSortMoney(money2, out money1, 2);// call function
			tbxMoney2.Text = money1.ToString();// Display results in textbox
			//money2 = money2 - (money1 * 2); // calculating how much is left of the "User Input" value
			money2 = LeftOverMoney(money2, money1, 2);

			TOSortMoney(money2, out money1, 1);// call function
			tbxMoney1.Text = money1.ToString();// Display results in textbox
			//money2 = money2 - (money1 * 1); // calculating how much is left of the "User Input" value
			money2 = LeftOverMoney(money2, money1, 1);

		}

		// Method in which out parameter is passed 
		// and this method returns the value of 
		// the passed parameter 
		public static void TOSortMoney(int money2, out int money1, int size)
		{
			money1 = money2 / size;
		}

		public int LeftOverMoney(int money2, int money1, int size)
		{
			return money2 - (money1 * size);
		}
	}
}
