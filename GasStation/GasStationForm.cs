using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
	public partial class GasStationForm : Form
	{
		GasStation gasStation;
		int time = 0;
		Timer timer;
		public GasStationForm()
		{
			InitializeComponent();
			Load += GasStationForm_Load;
		}

		private void GasStationForm_Load(object sender, EventArgs e)
		{			
			gasStation = new GasStation();
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
			timer.Start();
			LoadGas();
			LoadCafe();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			time++;
			if(time == 10)
			{
				DialogResult dr = MessageBox.Show("Next client?", "Next client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(dr == DialogResult.Yes)
				{
					Reset();
				}
				time = 0;
			}
		}
		private void Reset()
		{
			cbGas.SelectedIndex = 0;
			rbCount.Checked = true;
			tbGasCount.Text = "";
			tbGasSum.Text = "";

			foreach (Control item in gbGoods.Controls)
			{
				if (item is CheckBox)
				{
					CheckBox ch = item as CheckBox;
					ch.Checked = false;
					(ch.Tag as TextBox).Text = "";
				}
			}
			CalcGoodsSum();
			CalcGasSum();
		}
		private void LoadCafe()
		{
			int size = 30;
			for (int i = 0; i < gasStation.goods.Count; i++)
			{
				CheckBox chb = new CheckBox()
				{
					Name = $"chbGood{i}",
					Text = gasStation.goods[i].Name,
					Location = new Point(10, 40 + i * size),
					Size = new Size(140, 30),
				};
				chb.CheckedChanged += Cb_CheckedChanged;
				gbGoods.Controls.Add(chb);

				TextBox tbPrice = new TextBox()
				{
					Name = $"tbGoodPrice{i}",
					Text = gasStation.goods[i].Price.ToString("F2"),
					Location = new Point(150, 40 + i * size),
					Size = new Size(50, 10),
					Enabled = false,
					Font = new Font("Microsoft Sans Serif", 12f),
				};
				gbGoods.Controls.Add(tbPrice);

				TextBox tbCount = new TextBox()
				{
					Name = $"tbGoodCount{i}",
					Location = new Point(210, 40 + i * size),
					Size = new Size(70, 10),
					Enabled = false,
					Font = new Font("Microsoft Sans Serif", 12f),
					Tag = tbPrice,
				};
				tbCount.TextChanged += TbCount_TextChanged;
				gbGoods.Controls.Add(tbCount);
				chb.Tag = tbCount;				
			}
		}

		private void TbCount_TextChanged(object sender, EventArgs e)
		{
			CalcGoodsSum();			
		}

		private void Cb_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cb = sender as CheckBox;
			if (cb.Checked)
			{
				(cb.Tag as TextBox).Enabled = true;
				(cb.Tag as TextBox).Text = "";
			}
			else
			{
				(cb.Tag as TextBox).Enabled = false;
			}
			CalcGoodsSum();
		}
		private void CalcGoodsSum()
		{
			float sum = 0;
			foreach (Control item in gbGoods.Controls)
			{
				if(item is CheckBox)
				{
					CheckBox ch = item as CheckBox;
					if (ch.Checked)
					{
						if((ch.Tag as TextBox).Text.Length == 0)
						{
							continue;
						}
						float count = float.Parse((ch.Tag as TextBox).Text);
						float price = float.Parse(((ch.Tag as TextBox).Tag as TextBox).Text);
						sum += count * price;
					}
				}
			}
			lbCafeRes.Text = $"Sum : {sum} grn.";
			gasStation.GoodSum = sum;
			SetTotalSum();
		}
		private void LoadGas()
		{
			cbGas.DataSource = gasStation.gas.ToArray();
			cbGas.TextChanged += CbGas_TextChanged;
			cbGas.SelectedIndex = 0;
			lbGasPrice.Text = (cbGas.SelectedItem as GasData).Price.ToString();

			rbCount.CheckedChanged += Gas_CheckedChanged;
			rbSum.CheckedChanged += Gas_CheckedChanged;
			rbCount.Checked = true;

			tbGasCount.TextChanged += TbGasCount_TextChanged;
			tbGasSum.TextChanged += TbGasSum_TextChanged;
		}
		private void SetTotalSum()
		{
			lbTotalSum.Text = $"Total Sum : {gasStation.TotalSum:F2} grn.";
			time = 0;
		}
		private void TbGasSum_TextChanged(object sender, EventArgs e)
		{
			CalcGasSum();
		}
		private void CalcGasSum()
		{
			if (tbGasSum.Text.Length == 0)
			{
				return;
			}
			float sum = float.Parse(tbGasSum.Text);
			float price = float.Parse(lbGasPrice.Text);
			gasStation.GasSum = sum;
			SetTotalSum();
			lbGasRes.Text = $"Get {(sum / price):F2} l.";
		}
		private void TbGasCount_TextChanged(object sender, EventArgs e)
		{
			CalcGasCount();
		}
		private void CalcGasCount()
		{
			if (tbGasCount.Text.Length == 0)
			{
				return;
			}
			float count = float.Parse(tbGasCount.Text);
			float price = float.Parse(lbGasPrice.Text);
			gasStation.GasSum = count * price;
			SetTotalSum();
			lbGasRes.Text = $"Sum : {gasStation.GasSum:F2} grn.";
		}

		private void Gas_CheckedChanged(object sender, EventArgs e)
		{
			lbGasRes.Text = "-";
			if (rbSum.Checked)
			{
				tbGasSum.Enabled = true;
				tbGasSum.Text = "";
				tbGasCount.Enabled = false;
			}
			else
			{
				tbGasCount.Enabled = true;
				tbGasCount.Text = "";
				tbGasSum.Enabled = false;
			}
		}
		private void CbGas_TextChanged(object sender, EventArgs e)
		{
			lbGasPrice.Text = (cbGas.SelectedItem as GasData).Price.ToString();
			if (rbSum.Checked)
			{
				CalcGasSum();
			}
			else
			{
				CalcGasCount();
			}
			SetTotalSum();
		}
	}
}
