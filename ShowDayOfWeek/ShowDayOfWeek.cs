using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDayOfWeek
{
	public partial class ShowDayOfWeek : Form
	{
		public ShowDayOfWeek()
		{
			InitializeComponent();
			Load += ShowDayOfWeek_Load;
		}

		private void ShowDayOfWeek_Load(object sender, EventArgs e)
		{
			SetText();
			dtpDate.ValueChanged += DtpDate_ValueChanged;
		}

		private void DtpDate_ValueChanged(object sender, EventArgs e)
		{
			SetText();
		}
		private void SetText()
		{
			lbDayOfWeek.Text = dtpDate.Value.DayOfWeek.ToString();
		}
	}
}
