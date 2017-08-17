using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Sushmita Nandalan
 * Date: August 16, 2017
 * Student ID: 300923159
 * Description: This is the Splash Form
 * Version: 0.2  - Created SplashFormTimer. 
 */
namespace COMP123_S2017_Assignment5
{
	public partial class SplashForm : Form
	{
		public SplashForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// This is the event handler for the tick event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SplashFormTimer_Tick(object sender, EventArgs e)
		{
			BMICalculator bmiCalculator = new BMICalculator();
			bmiCalculator.Show();
			this.Hide();
			SplashFormTimer.Enabled = false; //turns timer off
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
