﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Sushmita Nandalan
 * Date: August 4, 2017
 * Student ID: 300923159
 * Description: BMI Calculator project
 * Version: 0.1 - Created the Project
 */
namespace COMP123_S2017_Assignment5
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new BMI_Calculator());
		}
	}
}
