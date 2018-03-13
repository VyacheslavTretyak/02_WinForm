namespace CoutDayToDate
{
	partial class CountDayToDate
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
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.rbHours = new System.Windows.Forms.RadioButton();
			this.rbSeconds = new System.Windows.Forms.RadioButton();
			this.rbMinutes = new System.Windows.Forms.RadioButton();
			this.rbDays = new System.Windows.Forms.RadioButton();
			this.rbMonths = new System.Windows.Forms.RadioButton();
			this.rbYears = new System.Windows.Forms.RadioButton();
			this.lbCountDay = new System.Windows.Forms.Label();
			this.tbYear = new System.Windows.Forms.TextBox();
			this.tbMonth = new System.Windows.Forms.TextBox();
			this.tbDay = new System.Windows.Forms.TextBox();
			this.btnCount = new System.Windows.Forms.Button();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox
			// 
			this.groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox.Controls.Add(this.rbHours);
			this.groupBox.Controls.Add(this.rbSeconds);
			this.groupBox.Controls.Add(this.rbMinutes);
			this.groupBox.Controls.Add(this.rbDays);
			this.groupBox.Controls.Add(this.rbMonths);
			this.groupBox.Controls.Add(this.rbYears);
			this.groupBox.Location = new System.Drawing.Point(118, -1);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(107, 169);
			this.groupBox.TabIndex = 1;
			this.groupBox.TabStop = false;
			// 
			// rbHours
			// 
			this.rbHours.AutoSize = true;
			this.rbHours.Location = new System.Drawing.Point(7, 88);
			this.rbHours.Name = "rbHours";
			this.rbHours.Size = new System.Drawing.Size(53, 17);
			this.rbHours.TabIndex = 5;
			this.rbHours.TabStop = true;
			this.rbHours.Text = "Hours";
			this.rbHours.UseVisualStyleBackColor = true;
			// 
			// rbSeconds
			// 
			this.rbSeconds.AutoSize = true;
			this.rbSeconds.Location = new System.Drawing.Point(5, 134);
			this.rbSeconds.Name = "rbSeconds";
			this.rbSeconds.Size = new System.Drawing.Size(67, 17);
			this.rbSeconds.TabIndex = 4;
			this.rbSeconds.TabStop = true;
			this.rbSeconds.Text = "Seconds";
			this.rbSeconds.UseVisualStyleBackColor = true;
			// 
			// rbMinutes
			// 
			this.rbMinutes.AutoSize = true;
			this.rbMinutes.Location = new System.Drawing.Point(5, 111);
			this.rbMinutes.Name = "rbMinutes";
			this.rbMinutes.Size = new System.Drawing.Size(62, 17);
			this.rbMinutes.TabIndex = 3;
			this.rbMinutes.TabStop = true;
			this.rbMinutes.Text = "Minutes";
			this.rbMinutes.UseVisualStyleBackColor = true;
			// 
			// rbDays
			// 
			this.rbDays.AutoSize = true;
			this.rbDays.Location = new System.Drawing.Point(7, 65);
			this.rbDays.Name = "rbDays";
			this.rbDays.Size = new System.Drawing.Size(49, 17);
			this.rbDays.TabIndex = 2;
			this.rbDays.TabStop = true;
			this.rbDays.Text = "Days";
			this.rbDays.UseVisualStyleBackColor = true;
			// 
			// rbMonths
			// 
			this.rbMonths.AutoSize = true;
			this.rbMonths.Location = new System.Drawing.Point(7, 42);
			this.rbMonths.Name = "rbMonths";
			this.rbMonths.Size = new System.Drawing.Size(60, 17);
			this.rbMonths.TabIndex = 1;
			this.rbMonths.TabStop = true;
			this.rbMonths.Text = "Months";
			this.rbMonths.UseVisualStyleBackColor = true;
			// 
			// rbYears
			// 
			this.rbYears.AutoSize = true;
			this.rbYears.Location = new System.Drawing.Point(7, 20);
			this.rbYears.Name = "rbYears";
			this.rbYears.Size = new System.Drawing.Size(52, 17);
			this.rbYears.TabIndex = 0;
			this.rbYears.TabStop = true;
			this.rbYears.Text = "Years";
			this.rbYears.UseVisualStyleBackColor = true;
			// 
			// lbCountDay
			// 
			this.lbCountDay.AutoSize = true;
			this.lbCountDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbCountDay.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.lbCountDay.Location = new System.Drawing.Point(5, 174);
			this.lbCountDay.Name = "lbCountDay";
			this.lbCountDay.Size = new System.Drawing.Size(35, 37);
			this.lbCountDay.TabIndex = 2;
			this.lbCountDay.Text = "0";
			// 
			// tbYear
			// 
			this.tbYear.AcceptsReturn = true;
			this.tbYear.AcceptsTab = true;
			this.tbYear.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.tbYear.Location = new System.Drawing.Point(12, 12);
			this.tbYear.Name = "tbYear";
			this.tbYear.Size = new System.Drawing.Size(100, 20);
			this.tbYear.TabIndex = 3;
			this.tbYear.Tag = "Year";
			this.tbYear.Text = "Year";
			// 
			// tbMonth
			// 
			this.tbMonth.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.tbMonth.Location = new System.Drawing.Point(12, 38);
			this.tbMonth.Name = "tbMonth";
			this.tbMonth.Size = new System.Drawing.Size(100, 20);
			this.tbMonth.TabIndex = 4;
			this.tbMonth.Tag = "Month";
			this.tbMonth.Text = "Month";
			// 
			// tbDay
			// 
			this.tbDay.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.tbDay.Location = new System.Drawing.Point(12, 64);
			this.tbDay.Name = "tbDay";
			this.tbDay.Size = new System.Drawing.Size(100, 20);
			this.tbDay.TabIndex = 5;
			this.tbDay.Tag = "Day";
			this.tbDay.Text = "Day";
			// 
			// btnCount
			// 
			this.btnCount.Location = new System.Drawing.Point(28, 90);
			this.btnCount.Name = "btnCount";
			this.btnCount.Size = new System.Drawing.Size(75, 23);
			this.btnCount.TabIndex = 6;
			this.btnCount.Text = "Count";
			this.btnCount.UseVisualStyleBackColor = true;
			// 
			// CountDayToDate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(242, 220);
			this.Controls.Add(this.btnCount);
			this.Controls.Add(this.tbDay);
			this.Controls.Add(this.tbMonth);
			this.Controls.Add(this.tbYear);
			this.Controls.Add(this.lbCountDay);
			this.Controls.Add(this.groupBox);
			this.ImeMode = System.Windows.Forms.ImeMode.On;
			this.Name = "CountDayToDate";
			this.Text = "CountDayToDate";
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.RadioButton rbSeconds;
		private System.Windows.Forms.RadioButton rbMinutes;
		private System.Windows.Forms.RadioButton rbDays;
		private System.Windows.Forms.RadioButton rbMonths;
		private System.Windows.Forms.RadioButton rbYears;
		private System.Windows.Forms.Label lbCountDay;
		private System.Windows.Forms.TextBox tbYear;
		private System.Windows.Forms.TextBox tbMonth;
		private System.Windows.Forms.TextBox tbDay;
		private System.Windows.Forms.Button btnCount;
		private System.Windows.Forms.RadioButton rbHours;
	}
}

