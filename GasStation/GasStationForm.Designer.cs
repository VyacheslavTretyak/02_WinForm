namespace GasStation
{
	partial class GasStationForm
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
			this.gbGas = new System.Windows.Forms.GroupBox();
			this.lbGasRes = new System.Windows.Forms.Label();
			this.gpQuantity = new System.Windows.Forms.GroupBox();
			this.lbGrnText = new System.Windows.Forms.Label();
			this.lbLText = new System.Windows.Forms.Label();
			this.tbGasSum = new System.Windows.Forms.TextBox();
			this.tbGasCount = new System.Windows.Forms.TextBox();
			this.rbSum = new System.Windows.Forms.RadioButton();
			this.rbCount = new System.Windows.Forms.RadioButton();
			this.lbGasPrice = new System.Windows.Forms.Label();
			this.lbGasPriceText = new System.Windows.Forms.Label();
			this.cbGas = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbCafe = new System.Windows.Forms.GroupBox();
			this.lbCafeRes = new System.Windows.Forms.Label();
			this.gbGoods = new System.Windows.Forms.GroupBox();
			this.lbGoodCountText = new System.Windows.Forms.Label();
			this.lbGoodPriceText = new System.Windows.Forms.Label();
			this.lbTotalSum = new System.Windows.Forms.Label();
			this.gbGas.SuspendLayout();
			this.gpQuantity.SuspendLayout();
			this.gbCafe.SuspendLayout();
			this.gbGoods.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbGas
			// 
			this.gbGas.BackColor = System.Drawing.Color.ForestGreen;
			this.gbGas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.gbGas.Controls.Add(this.lbGasRes);
			this.gbGas.Controls.Add(this.gpQuantity);
			this.gbGas.Controls.Add(this.lbGasPrice);
			this.gbGas.Controls.Add(this.lbGasPriceText);
			this.gbGas.Controls.Add(this.cbGas);
			this.gbGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbGas.ForeColor = System.Drawing.Color.PaleGreen;
			this.gbGas.Location = new System.Drawing.Point(12, 106);
			this.gbGas.Name = "gbGas";
			this.gbGas.Size = new System.Drawing.Size(299, 265);
			this.gbGas.TabIndex = 0;
			this.gbGas.TabStop = false;
			this.gbGas.Text = "Gas";
			// 
			// lbGasRes
			// 
			this.lbGasRes.AutoSize = true;
			this.lbGasRes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbGasRes.ForeColor = System.Drawing.Color.Orange;
			this.lbGasRes.Location = new System.Drawing.Point(3, 236);
			this.lbGasRes.Name = "lbGasRes";
			this.lbGasRes.Size = new System.Drawing.Size(19, 26);
			this.lbGasRes.TabIndex = 4;
			this.lbGasRes.Text = "-";
			// 
			// gpQuantity
			// 
			this.gpQuantity.Controls.Add(this.lbGrnText);
			this.gpQuantity.Controls.Add(this.lbLText);
			this.gpQuantity.Controls.Add(this.tbGasSum);
			this.gpQuantity.Controls.Add(this.tbGasCount);
			this.gpQuantity.Controls.Add(this.rbSum);
			this.gpQuantity.Controls.Add(this.rbCount);
			this.gpQuantity.Location = new System.Drawing.Point(12, 102);
			this.gpQuantity.Name = "gpQuantity";
			this.gpQuantity.Size = new System.Drawing.Size(281, 103);
			this.gpQuantity.TabIndex = 3;
			this.gpQuantity.TabStop = false;
			// 
			// lbGrnText
			// 
			this.lbGrnText.AutoSize = true;
			this.lbGrnText.ForeColor = System.Drawing.Color.Silver;
			this.lbGrnText.Location = new System.Drawing.Point(230, 60);
			this.lbGrnText.Name = "lbGrnText";
			this.lbGrnText.Size = new System.Drawing.Size(49, 26);
			this.lbGrnText.TabIndex = 5;
			this.lbGrnText.Text = "grn.";
			// 
			// lbLText
			// 
			this.lbLText.AutoSize = true;
			this.lbLText.ForeColor = System.Drawing.Color.Silver;
			this.lbLText.Location = new System.Drawing.Point(230, 24);
			this.lbLText.Name = "lbLText";
			this.lbLText.Size = new System.Drawing.Size(23, 26);
			this.lbLText.TabIndex = 4;
			this.lbLText.Text = "l.";
			// 
			// tbGasSum
			// 
			this.tbGasSum.Location = new System.Drawing.Point(100, 58);
			this.tbGasSum.Name = "tbGasSum";
			this.tbGasSum.Size = new System.Drawing.Size(123, 32);
			this.tbGasSum.TabIndex = 3;
			// 
			// tbGasCount
			// 
			this.tbGasCount.Location = new System.Drawing.Point(101, 20);
			this.tbGasCount.Name = "tbGasCount";
			this.tbGasCount.Size = new System.Drawing.Size(123, 32);
			this.tbGasCount.TabIndex = 2;
			// 
			// rbSum
			// 
			this.rbSum.AutoSize = true;
			this.rbSum.Location = new System.Drawing.Point(7, 56);
			this.rbSum.Name = "rbSum";
			this.rbSum.Size = new System.Drawing.Size(76, 30);
			this.rbSum.TabIndex = 1;
			this.rbSum.TabStop = true;
			this.rbSum.Text = "Sum";
			this.rbSum.UseVisualStyleBackColor = true;
			// 
			// rbCount
			// 
			this.rbCount.AutoSize = true;
			this.rbCount.Location = new System.Drawing.Point(7, 20);
			this.rbCount.Name = "rbCount";
			this.rbCount.Size = new System.Drawing.Size(88, 30);
			this.rbCount.TabIndex = 0;
			this.rbCount.TabStop = true;
			this.rbCount.Text = "Count";
			this.rbCount.UseVisualStyleBackColor = true;
			// 
			// lbGasPrice
			// 
			this.lbGasPrice.AutoSize = true;
			this.lbGasPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbGasPrice.ForeColor = System.Drawing.Color.Chartreuse;
			this.lbGasPrice.Location = new System.Drawing.Point(93, 72);
			this.lbGasPrice.Name = "lbGasPrice";
			this.lbGasPrice.Size = new System.Drawing.Size(62, 29);
			this.lbGasPrice.TabIndex = 2;
			this.lbGasPrice.Text = "0.00";
			// 
			// lbGasPriceText
			// 
			this.lbGasPriceText.AutoSize = true;
			this.lbGasPriceText.ForeColor = System.Drawing.Color.Silver;
			this.lbGasPriceText.Location = new System.Drawing.Point(7, 72);
			this.lbGasPriceText.Name = "lbGasPriceText";
			this.lbGasPriceText.Size = new System.Drawing.Size(80, 26);
			this.lbGasPriceText.TabIndex = 1;
			this.lbGasPriceText.Text = "Price : ";
			// 
			// cbGas
			// 
			this.cbGas.BackColor = System.Drawing.Color.YellowGreen;
			this.cbGas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGas.FormattingEnabled = true;
			this.cbGas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbGas.Location = new System.Drawing.Point(7, 32);
			this.cbGas.Name = "cbGas";
			this.cbGas.Size = new System.Drawing.Size(284, 33);
			this.cbGas.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Light", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 89);
			this.label1.TabIndex = 1;
			this.label1.Text = "BestOil";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gbCafe
			// 
			this.gbCafe.AutoSize = true;
			this.gbCafe.BackColor = System.Drawing.Color.DarkOrange;
			this.gbCafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.gbCafe.Controls.Add(this.lbCafeRes);
			this.gbCafe.Controls.Add(this.gbGoods);
			this.gbCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbCafe.ForeColor = System.Drawing.Color.ForestGreen;
			this.gbCafe.Location = new System.Drawing.Point(329, 106);
			this.gbCafe.Name = "gbCafe";
			this.gbCafe.Size = new System.Drawing.Size(318, 262);
			this.gbCafe.TabIndex = 5;
			this.gbCafe.TabStop = false;
			this.gbCafe.Text = "MiniCafe";
			// 
			// lbCafeRes
			// 
			this.lbCafeRes.AutoSize = true;
			this.lbCafeRes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbCafeRes.ForeColor = System.Drawing.Color.DarkGreen;
			this.lbCafeRes.Location = new System.Drawing.Point(3, 233);
			this.lbCafeRes.Name = "lbCafeRes";
			this.lbCafeRes.Size = new System.Drawing.Size(161, 26);
			this.lbCafeRes.TabIndex = 5;
			this.lbCafeRes.Text = "Sum : 0.00 grn.";
			// 
			// gbGoods
			// 
			this.gbGoods.AutoSize = true;
			this.gbGoods.Controls.Add(this.lbGoodCountText);
			this.gbGoods.Controls.Add(this.lbGoodPriceText);
			this.gbGoods.Location = new System.Drawing.Point(12, 31);
			this.gbGoods.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.gbGoods.Name = "gbGoods";
			this.gbGoods.Size = new System.Drawing.Size(290, 174);
			this.gbGoods.TabIndex = 3;
			this.gbGoods.TabStop = false;
			// 
			// lbGoodCountText
			// 
			this.lbGoodCountText.AutoSize = true;
			this.lbGoodCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbGoodCountText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbGoodCountText.Location = new System.Drawing.Point(214, 14);
			this.lbGoodCountText.Name = "lbGoodCountText";
			this.lbGoodCountText.Size = new System.Drawing.Size(49, 20);
			this.lbGoodCountText.TabIndex = 3;
			this.lbGoodCountText.Text = "count";
			// 
			// lbGoodPriceText
			// 
			this.lbGoodPriceText.AutoSize = true;
			this.lbGoodPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbGoodPriceText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbGoodPriceText.Location = new System.Drawing.Point(154, 14);
			this.lbGoodPriceText.Name = "lbGoodPriceText";
			this.lbGoodPriceText.Size = new System.Drawing.Size(43, 20);
			this.lbGoodPriceText.TabIndex = 2;
			this.lbGoodPriceText.Text = "price";
			// 
			// lbTotalSum
			// 
			this.lbTotalSum.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lbTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTotalSum.ForeColor = System.Drawing.Color.SaddleBrown;
			this.lbTotalSum.Location = new System.Drawing.Point(0, 408);
			this.lbTotalSum.Name = "lbTotalSum";
			this.lbTotalSum.Size = new System.Drawing.Size(659, 37);
			this.lbTotalSum.TabIndex = 0;
			this.lbTotalSum.Text = "Total Sum :  ";
			// 
			// GasStationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.YellowGreen;
			this.ClientSize = new System.Drawing.Size(659, 445);
			this.Controls.Add(this.lbTotalSum);
			this.Controls.Add(this.gbCafe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbGas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "GasStationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BestOil";
			this.gbGas.ResumeLayout(false);
			this.gbGas.PerformLayout();
			this.gpQuantity.ResumeLayout(false);
			this.gpQuantity.PerformLayout();
			this.gbCafe.ResumeLayout(false);
			this.gbCafe.PerformLayout();
			this.gbGoods.ResumeLayout(false);
			this.gbGoods.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbGas;
		private System.Windows.Forms.Label lbGasPrice;
		private System.Windows.Forms.Label lbGasPriceText;
		private System.Windows.Forms.ComboBox cbGas;
		private System.Windows.Forms.GroupBox gpQuantity;
		private System.Windows.Forms.Label lbGrnText;
		private System.Windows.Forms.Label lbLText;
		private System.Windows.Forms.TextBox tbGasSum;
		private System.Windows.Forms.TextBox tbGasCount;
		private System.Windows.Forms.RadioButton rbSum;
		private System.Windows.Forms.RadioButton rbCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbGasRes;
		private System.Windows.Forms.GroupBox gbCafe;
		private System.Windows.Forms.GroupBox gbGoods;
		private System.Windows.Forms.Label lbGoodPriceText;
		private System.Windows.Forms.Label lbGoodCountText;
		private System.Windows.Forms.Label lbCafeRes;
		private System.Windows.Forms.Label lbTotalSum;
	}
}

