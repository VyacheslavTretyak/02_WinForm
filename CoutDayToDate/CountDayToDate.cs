using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoutDayToDate
{
	public partial class CountDayToDate : Form
	{
		public CountDayToDate()
		{
			InitializeComponent();
			Load += CountDayToDate_Load;
		}

		private void CountDayToDate_Load(object sender, EventArgs e)
		{
			tbYear.Enter += TextBox_Enter;
			tbYear.Leave += TbYear_Leave;
			tbYear.KeyPress += TextBox_KeyPress;
			tbMonth.Enter += TextBox_Enter;
			tbMonth.Leave += TbMonth_Leave;
			tbMonth.KeyPress += TextBox_KeyPress;
			tbDay.Enter += TextBox_Enter;
			tbDay.Leave += TbDay_Leave;
			tbDay.KeyPress += TextBox_KeyPress;
			btnCount.Click += BtnCount_Click;
		}
		private void BtnCount_Click(object sender, EventArgs e)
		{
			bool isError = false;
			foreach (Control item in Controls)
			{
				if(item is TextBox)
				{
					if(IsEmpty(item as TextBox))
					{
						item.BackColor = Color.Red;
						isError = true;
					}
				}
			}
			if (!isError)
			{
				string cheched = "";
				foreach (RadioButton item in groupBox.Controls)
				{
					if (item.Checked)
					{
						cheched = item.Text;
					}
				}
				TimeSpan ts;
				switch (cheched)
				{
					case "Years":
						ts = Calculation();
						lbCountDay.Text = (ts.TotalDays / 365f).ToString();
						break;
					case "Months":
						ts = Calculation();
						lbCountDay.Text = (ts.TotalDays / 30f).ToString();
						break;
					case "Days":
						ts = Calculation();
						lbCountDay.Text = ts.TotalDays.ToString();
						break;
					case "Hours":
						ts = Calculation();
						lbCountDay.Text = ts.TotalHours.ToString();
						break;
					case "Minutes":
						ts = Calculation();
						lbCountDay.Text = ts.TotalMinutes.ToString();
						break;
					case "Seconds":
						ts = Calculation();
						lbCountDay.Text = ts.TotalSeconds.ToString();
						break;
				}
			}
		}
		private TimeSpan Calculation()
		{
			int year = int.Parse(tbYear.Text);
			int month = int.Parse(tbMonth.Text);
			int day = int.Parse(tbDay.Text);
			DateTime dt = new DateTime(year, month, day);
			return DateTime.Now.Subtract(dt);			
		}

		private void TbDay_Leave(object sender, EventArgs e)
		{
			LeaveControl(sender);
			ReCalculateDay();					
		}
		private void ReCalculateDay()
		{
			if (IsEmpty(tbMonth) || IsEmpty(tbYear) || IsEmpty(tbDay))
			{
				return;
			}
			int month = int.Parse(tbMonth.Text);
			int year = int.Parse(tbYear.Text);
			int day = int.Parse(tbDay.Text);
			int dayIsMonth = DateTime.DaysInMonth(year, month);
			if (day < 1 || day > dayIsMonth)
			{
				tbDay.Text = dayIsMonth.ToString();
			}
		}
		private void TbMonth_Leave(object sender, EventArgs e)
		{
			LeaveControl(sender);
			if (!IsEmpty(tbMonth))
			{
				int month = int.Parse(tbMonth.Text);
				if (month < 1 || month > 12)
				{
					tbMonth.Text = "12";					
				}
			}
			ReCalculateDay();					
		}

		private void TbYear_Leave(object sender, EventArgs e)
		{
			LeaveControl(sender);
			ReCalculateDay();			
		}

		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13;
		}
		private void TextBox_Enter(object sender, EventArgs e)
		{			
			TextBox tb = sender as TextBox;
			tb.BackColor = System.Drawing.SystemColors.Window;
			if(tb.Text == (tb.Tag as string))
			{
				tb.Text = "";
				tb.ForeColor = Color.Black;
			}
		}
		private bool IsEmpty(TextBox tb)
		{
			if (tb.Text == (tb.Tag as string))
			{
				return true;
			}
			return false;
		}
		private void LeaveControl(object sender)
		{
			TextBox tb = sender as TextBox;
			tb.Text.Trim();
			if (tb.Text == "")
			{
				tb.Text = tb.Tag as string;
				tb.ForeColor = System.Drawing.SystemColors.ScrollBar;
			}
		}
	}
}
