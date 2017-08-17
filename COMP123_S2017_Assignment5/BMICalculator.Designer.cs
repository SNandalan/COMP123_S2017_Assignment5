namespace COMP123_S2017_Assignment5
{
	partial class BMICalculator
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
			this.MetricRadioButton = new System.Windows.Forms.RadioButton();
			this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
			this.HeightTextBox = new System.Windows.Forms.TextBox();
			this.HeightLabel = new System.Windows.Forms.Label();
			this.CalculateBMIButton = new System.Windows.Forms.Button();
			this.WeightLabel = new System.Windows.Forms.Label();
			this.WeightTextBox = new System.Windows.Forms.TextBox();
			this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
			this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.ClearButton = new System.Windows.Forms.Button();
			this.BMIResultTextBox = new System.Windows.Forms.TextBox();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
			this.TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// MetricRadioButton
			// 
			this.MetricRadioButton.AutoSize = true;
			this.MetricRadioButton.Location = new System.Drawing.Point(12, 6);
			this.MetricRadioButton.Name = "MetricRadioButton";
			this.MetricRadioButton.Size = new System.Drawing.Size(127, 42);
			this.MetricRadioButton.TabIndex = 2;
			this.MetricRadioButton.TabStop = true;
			this.MetricRadioButton.Text = "Metric";
			this.MetricRadioButton.UseVisualStyleBackColor = true;
			this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// ImperialRadioButton
			// 
			this.ImperialRadioButton.AutoSize = true;
			this.ImperialRadioButton.Location = new System.Drawing.Point(156, 6);
			this.ImperialRadioButton.Name = "ImperialRadioButton";
			this.ImperialRadioButton.Size = new System.Drawing.Size(152, 42);
			this.ImperialRadioButton.TabIndex = 3;
			this.ImperialRadioButton.TabStop = true;
			this.ImperialRadioButton.Text = "Imperial";
			this.ImperialRadioButton.UseVisualStyleBackColor = true;
			// 
			// HeightTextBox
			// 
			this.HeightTextBox.Location = new System.Drawing.Point(174, 3);
			this.HeightTextBox.Multiline = true;
			this.HeightTextBox.Name = "HeightTextBox";
			this.HeightTextBox.Size = new System.Drawing.Size(70, 40);
			this.HeightTextBox.TabIndex = 3;
			// 
			// HeightLabel
			// 
			this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.HeightLabel.AutoSize = true;
			this.HeightLabel.Location = new System.Drawing.Point(3, 7);
			this.HeightLabel.MaximumSize = new System.Drawing.Size(0, 45);
			this.HeightLabel.Name = "HeightLabel";
			this.HeightLabel.Padding = new System.Windows.Forms.Padding(2);
			this.HeightLabel.Size = new System.Drawing.Size(124, 45);
			this.HeightLabel.TabIndex = 2;
			this.HeightLabel.Text = "My  Height:";
			// 
			// CalculateBMIButton
			// 
			this.CalculateBMIButton.Location = new System.Drawing.Point(3, 121);
			this.CalculateBMIButton.MinimumSize = new System.Drawing.Size(0, 40);
			this.CalculateBMIButton.Name = "CalculateBMIButton";
			this.CalculateBMIButton.Size = new System.Drawing.Size(165, 50);
			this.CalculateBMIButton.TabIndex = 6;
			this.CalculateBMIButton.Text = "Calculate";
			this.CalculateBMIButton.UseVisualStyleBackColor = true;
			this.CalculateBMIButton.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// WeightLabel
			// 
			this.WeightLabel.AutoSize = true;
			this.WeightLabel.Location = new System.Drawing.Point(3, 59);
			this.WeightLabel.Name = "WeightLabel";
			this.WeightLabel.Size = new System.Drawing.Size(127, 59);
			this.WeightLabel.TabIndex = 5;
			this.WeightLabel.Text = "My Weight:";
			this.WeightLabel.Click += new System.EventHandler(this.labelWeight_Click);
			// 
			// WeightTextBox
			// 
			this.WeightTextBox.Location = new System.Drawing.Point(174, 62);
			this.WeightTextBox.Multiline = true;
			this.WeightTextBox.Name = "WeightTextBox";
			this.WeightTextBox.Size = new System.Drawing.Size(70, 40);
			this.WeightTextBox.TabIndex = 4;
			// 
			// BMIScaleTextBox
			// 
			this.BMIScaleTextBox.BackColor = System.Drawing.Color.White;
			this.BMIScaleTextBox.Enabled = false;
			this.BMIScaleTextBox.Location = new System.Drawing.Point(11, 338);
			this.BMIScaleTextBox.Multiline = true;
			this.BMIScaleTextBox.Name = "BMIScaleTextBox";
			this.BMIScaleTextBox.ReadOnly = true;
			this.BMIScaleTextBox.Size = new System.Drawing.Size(276, 83);
			this.BMIScaleTextBox.TabIndex = 1;
			this.BMIScaleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TableLayout
			// 
			this.TableLayout.ColumnCount = 2;
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.39597F));
			this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.60403F));
			this.TableLayout.Controls.Add(this.HeightLabel, 0, 0);
			this.TableLayout.Controls.Add(this.WeightLabel, 0, 1);
			this.TableLayout.Controls.Add(this.WeightTextBox, 1, 1);
			this.TableLayout.Controls.Add(this.CalculateBMIButton, 0, 2);
			this.TableLayout.Controls.Add(this.ClearButton, 1, 2);
			this.TableLayout.Controls.Add(this.HeightTextBox, 1, 0);
			this.TableLayout.Controls.Add(this.BMIResultTextBox, 1, 3);
			this.TableLayout.Controls.Add(this.ResultLabel, 0, 3);
			this.TableLayout.Location = new System.Drawing.Point(1, 54);
			this.TableLayout.Name = "TableLayout";
			this.TableLayout.RowCount = 4;
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayout.Size = new System.Drawing.Size(289, 239);
			this.TableLayout.TabIndex = 0;
			this.TableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayout_Paint);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(174, 121);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(112, 50);
			this.ClearButton.TabIndex = 7;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			// 
			// BMIResultTextBox
			// 
			this.BMIResultTextBox.Location = new System.Drawing.Point(174, 180);
			this.BMIResultTextBox.Name = "BMIResultTextBox";
			this.BMIResultTextBox.Size = new System.Drawing.Size(100, 45);
			this.BMIResultTextBox.TabIndex = 9;
			// 
			// ResultLabel
			// 
			this.ResultLabel.Location = new System.Drawing.Point(3, 177);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(165, 48);
			this.ResultLabel.TabIndex = 8;
			this.ResultLabel.Text = "Result";
			this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
			// 
			// BMIProgressBar
			// 
			this.BMIProgressBar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.BMIProgressBar.Location = new System.Drawing.Point(12, 300);
			this.BMIProgressBar.Name = "BMIProgressBar";
			this.BMIProgressBar.Size = new System.Drawing.Size(275, 23);
			this.BMIProgressBar.TabIndex = 4;
			this.BMIProgressBar.Click += new System.EventHandler(this.BMIProgressBar_Click);
			// 
			// BMICalculator
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(302, 433);
			this.Controls.Add(this.BMIProgressBar);
			this.Controls.Add(this.BMIScaleTextBox);
			this.Controls.Add(this.ImperialRadioButton);
			this.Controls.Add(this.MetricRadioButton);
			this.Controls.Add(this.TableLayout);
			this.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BMICalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BMICalculator";
			this.TableLayout.ResumeLayout(false);
			this.TableLayout.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton MetricRadioButton;
		private System.Windows.Forms.RadioButton ImperialRadioButton;
		private System.Windows.Forms.TextBox HeightTextBox;
		private System.Windows.Forms.Label HeightLabel;
		private System.Windows.Forms.Button CalculateBMIButton;
		private System.Windows.Forms.Label WeightLabel;
		private System.Windows.Forms.TextBox WeightTextBox;
		private System.Windows.Forms.TextBox BMIScaleTextBox;
		private System.Windows.Forms.TableLayoutPanel TableLayout;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.TextBox BMIResultTextBox;
		private System.Windows.Forms.Label ResultLabel;
		private System.Windows.Forms.ProgressBar BMIProgressBar;
	}
}

