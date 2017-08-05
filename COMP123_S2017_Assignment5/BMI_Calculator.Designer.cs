namespace COMP123_S2017_Assignment5
{
	partial class BMI_Calculator
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
			this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.Result = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.labelHeight = new System.Windows.Forms.Label();
			this.textBoxHeight = new System.Windows.Forms.TextBox();
			this.textBoxWeight = new System.Windows.Forms.TextBox();
			this.labelWeight = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.tableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayout
			// 
			this.tableLayout.ColumnCount = 1;
			this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayout.Controls.Add(this.labelHeight, 0, 0);
			this.tableLayout.Controls.Add(this.Result, 0, 5);
			this.tableLayout.Controls.Add(this.textBoxHeight, 0, 1);
			this.tableLayout.Controls.Add(this.textBoxWeight, 0, 3);
			this.tableLayout.Controls.Add(this.labelWeight, 0, 2);
			this.tableLayout.Controls.Add(this.buttonCalculate, 0, 4);
			this.tableLayout.Location = new System.Drawing.Point(1, 54);
			this.tableLayout.Name = "tableLayout";
			this.tableLayout.RowCount = 6;
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayout.Size = new System.Drawing.Size(298, 237);
			this.tableLayout.TabIndex = 0;
			this.tableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayout_Paint);
			// 
			// Result
			// 
			this.Result.BackColor = System.Drawing.Color.White;
			this.Result.Enabled = false;
			this.Result.Location = new System.Drawing.Point(3, 198);
			this.Result.Multiline = true;
			this.Result.Name = "Result";
			this.Result.ReadOnly = true;
			this.Result.Size = new System.Drawing.Size(286, 36);
			this.Result.TabIndex = 1;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(12, 6);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(127, 42);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Metric";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(156, 6);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(152, 42);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Imperial";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// labelHeight
			// 
			this.labelHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelHeight.AutoSize = true;
			this.labelHeight.Location = new System.Drawing.Point(3, 0);
			this.labelHeight.MaximumSize = new System.Drawing.Size(0, 45);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Padding = new System.Windows.Forms.Padding(2);
			this.labelHeight.Size = new System.Drawing.Size(186, 39);
			this.labelHeight.TabIndex = 2;
			this.labelHeight.Text = "My  Height:";
			// 
			// textBoxHeight
			// 
			this.textBoxHeight.Location = new System.Drawing.Point(3, 42);
			this.textBoxHeight.Multiline = true;
			this.textBoxHeight.Name = "textBoxHeight";
			this.textBoxHeight.Size = new System.Drawing.Size(286, 33);
			this.textBoxHeight.TabIndex = 3;
			// 
			// textBoxWeight
			// 
			this.textBoxWeight.Location = new System.Drawing.Point(3, 120);
			this.textBoxWeight.Multiline = true;
			this.textBoxWeight.Name = "textBoxWeight";
			this.textBoxWeight.Size = new System.Drawing.Size(286, 33);
			this.textBoxWeight.TabIndex = 4;
			// 
			// labelWeight
			// 
			this.labelWeight.AutoSize = true;
			this.labelWeight.Location = new System.Drawing.Point(3, 78);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new System.Drawing.Size(180, 38);
			this.labelWeight.TabIndex = 5;
			this.labelWeight.Text = "My Weight:";
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(3, 159);
			this.buttonCalculate.MinimumSize = new System.Drawing.Size(0, 40);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(286, 40);
			this.buttonCalculate.TabIndex = 6;
			this.buttonCalculate.Text = "Calculate BMI";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			// 
			// BMI_Calculator
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(302, 433);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.tableLayout);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BMI_Calculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BMR_Calculator";
			this.tableLayout.ResumeLayout(false);
			this.tableLayout.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayout;
		private System.Windows.Forms.TextBox Result;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label labelHeight;
		private System.Windows.Forms.TextBox textBoxHeight;
		private System.Windows.Forms.TextBox textBoxWeight;
		private System.Windows.Forms.Label labelWeight;
		private System.Windows.Forms.Button buttonCalculate;
	}
}

