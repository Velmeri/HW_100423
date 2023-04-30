using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HW_100423
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			GasOil.DropDownStyle = ComboBoxStyle.DropDownList;
			GasOil.SelectedIndex = 0;
			tCount.Text = "0";
			GasOilPrice.Text = "";
			CafePrice.Text = "";
			AllPrice.Text = "";
			this.Text = "GasOil";
		}

		private void Count_Click(object sender, EventArgs e)
		{
			double GOSum, CSum ;
			string[] a = GasOilPrice.Text.Split(' ');
			string[] b = CafePrice.Text.Split(' ');
			if (double.TryParse(a[0], out GOSum) 
				&& double.TryParse(b[0], out CSum)) {
				AllPrice.Text = (GOSum + CSum).ToString() + " грн.";
			} else {
				AllPrice.Text = "ERROR";
			}
		}

		private void rCount_CheckedChanged(object sender, EventArgs e)
		{
			if (rCount.Checked) {
				tCount.ReadOnly = false;
				tSum.ReadOnly = true;
			} else if(rSum.Checked) {
				tSum.ReadOnly = false;
				tCount.ReadOnly = true;
			}
		}

		private void GasOil_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (GasOil.SelectedIndex) {
				case 0: {
						tGasOilPrice.Text = "44.79";
						break;
					}
				case 1: {
						tGasOilPrice.Text = "46.55";
						break;
					}
			}
			if (Regex.IsMatch(tCount.Text, @"^(\d+(\.\d+)?|\.\d+|\s*)$")) {
				double count, gasOilPrice, sum;
				if (double.TryParse(tCount.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out count)
					&& double.TryParse(tGasOilPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out gasOilPrice)) {
					sum = count * gasOilPrice;
					tSum.Text = sum.ToString();
				} else {
					tSum.Text = "ERROR";
				}
			}
		}

		private void tCount_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(tCount.Text, @"^(\d+(\.\d+)?|\.\d+|\s*)$")) {
				if (rCount.Checked) {
					double count, gasOilPrice, sum;
					if (double.TryParse(tCount.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out count)
						&& double.TryParse(tGasOilPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out gasOilPrice)) {
						sum = count * gasOilPrice;
						tSum.Text = sum.ToString();
					} else {
						tSum.Text = "ERROR";
					}
				}
			}
		}

		private void tSum_TextChanged(object sender, EventArgs e)
		{
			if (Regex.IsMatch(tSum.Text, @"^(\d+(\.\d+)?|\.\d+|\s*)$")) {
				if (rSum.Checked) {
					double sum, gasOilPrice, count;
					if (double.TryParse(tSum.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out sum)
						&& double.TryParse(tGasOilPrice.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out gasOilPrice)) {
						count = sum / gasOilPrice;
						tCount.Text = count.ToString();
					} else {
						tSum.Text = "ERROR";
					}
				}
			}

			GasOilPrice.Text = tSum.Text + " грн.";
		}

		private void Cafe_Count_Changed(object sender, EventArgs e)
		{
			double hotDogCount, hotDogPrice, hamburgerCount, hamburgerPrice, frenchFryCount, frenchFryPrice, colaCount, colaPrice;
			if (double.TryParse(tHotDogCount.Text, out hotDogCount) && double.TryParse(tHotDogPrice.Text, out hotDogPrice)
				&& double.TryParse(tHamburgerCount.Text, out hamburgerCount) && double.TryParse(tHamburgerPrice.Text, out hamburgerPrice)
				&& double.TryParse(tFrenchFryCount.Text, out frenchFryCount) && double.TryParse(tFrachFryPrice.Text, out frenchFryPrice)
				&& double.TryParse(tColaCount.Text, out colaCount) && double.TryParse(tColaPrice.Text, out colaPrice)) {
				double sum = 0;
				sum += hotDogCount * hotDogPrice;
				sum += hamburgerCount * hamburgerPrice;
				sum += frenchFryCount * frenchFryPrice;
				sum += colaCount * colaPrice;
				CafePrice.Text = sum.ToString() + " грн.";
			} else {
				CafePrice.Text = "ERROR";
			}
		}

		private void checkHotDog_CheckedChanged(object sender, EventArgs e)
		{
			if (checkHotDog.Checked) tHotDogCount.ReadOnly = false;
			else {
				tHotDogCount.ReadOnly = true;
				tHotDogCount.Text = "0";
			}
		}

		private void checkHamburger_CheckedChanged(object sender, EventArgs e)
		{
			if (checkHamburger.Checked) tHamburgerCount.ReadOnly = false;
			else {
				tHamburgerCount.ReadOnly = true;
				tHamburgerCount.Text = "0";
			}
		}

		private void checkFrenchFry_CheckedChanged(object sender, EventArgs e)
		{
			if (checkFrenchFry.Checked) tFrenchFryCount.ReadOnly = false;
			else {
				tFrenchFryCount.ReadOnly = true;
				tFrenchFryCount.Text = "0";
			}
		}

		private void checkCola_CheckedChanged(object sender, EventArgs e)
		{
			if (checkCola.Checked) tColaCount.ReadOnly = false;
			else {
				tColaCount.ReadOnly = true;
				tColaCount.Text = "0";
			}
		}
	}
}
