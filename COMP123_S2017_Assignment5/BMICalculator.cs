﻿using System;
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
 * Date: August 15, 2017
 * Student ID: 300923159
 * Description: BMI Calculator project
 * Version: 0.2  - Finished calculator functions. 
 */

namespace COMP123_S2017_Assignment5
{
	public partial class BMICalculator : Form
	{
		//PRIVATE INSTANCE VARIABLES

		double weight;
		double height;
		double bmiResult;

		//PUBLIC PROPERTIES

		//CONSTRUCTOR
		/// <summary>
		/// This is the main constructor for BMI Calculator.
		/// </summary>
		public BMICalculator()
		{
			InitializeComponent();
		}

		//PRIVATE METHODS
		
			/// <summary>
			/// This method calculates the BMI.
			/// It takes 2 arguments heightInput(double) and weightInput(double).
			/// </summary>
			/// <param name="heightInput"></param>
			/// <param name="weightInput"></param>
		private void CalculateBMI(double heightInput, double weightInput)
		{
			if (MetricRadioButton.Checked)
			{
				bmiResult = weightInput / (heightInput * heightInput);
			}
			else if (ImperialRadioButton.Checked)
			{
				bmiResult = (weightInput * 703) / (heightInput * heightInput);
			}

			bmiScale(bmiResult);
			BMIResultTextBox.Text = bmiResult.ToString("0.00");

			//Set value for progress bar
			int progressValue = Convert.ToInt32(bmiResult);
			progressValue = Math.Min(progressValue, 15);
			progressValue = Math.Max(progressValue, 45);
		    BMIProgressBar.Value = progressValue;
	      
		}
		/// <summary>
		/// This method checks of the value entered is valid.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				height = Convert.ToDouble(HeightTextBox.Text);
				weight = Convert.ToDouble(WeightTextBox.Text);
				CalculateBMI(height, weight);
			}
			catch (Exception)
			{
				MessageBox.Show("Invalid number");
				HeightTextBox.Clear();
				WeightTextBox.Clear();
				HeightTextBox.Focus();
			}
		}

		/// <summary>
		/// This method sets the bmi scale according to the bmi result. 
		/// </summary>
		/// <param name="result"></param>
		private void bmiScale(double result)
		{
			if (result < 18.5)
			{
				BMIScaleTextBox.Text = "Your BMI Scale is: Underweight";
			}
			else if ((result >= 18.5) && (result < 24.9))
			{
				BMIScaleTextBox.Text = "Your BMI Scale is: Normal";				
			}
			else if ((result >= 25) && (result < 29.9))
			{
				BMIScaleTextBox.Text = "Your BMI Scale is: Overweight";			
			}
			else if (result >= 30)
			{
				BMIScaleTextBox.Text = "Your BMI Scale is: Obese";
			}
		}

		/// <summary>
		/// This method clears all the fields in the form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearButton_Click_1(object sender, EventArgs e)
		{
			HeightTextBox.Clear();
			WeightTextBox.Clear();
			BMIResultTextBox.Clear();
			BMIScaleTextBox.Clear();
			HeightTextBox.Focus();
		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void tableLayout_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void labelWeight_Click(object sender, EventArgs e)
		{

		}

		

		private void ResultLabel_Click(object sender, EventArgs e)
		{

		}

		private void BMIProgressBar_Click(object sender, EventArgs e)
		{

		}

		private void BMICalculator_Load(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// This is the event handler to quit application on form close.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BMICalculator_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
