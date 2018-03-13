namespace ShowDayOfWeek
{
	partial class ShowDayOfWeek
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
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.lbDayOfWeek = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(12, 12);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 0;
			// 
			// lbDayOfWeek
			// 
			this.lbDayOfWeek.AutoSize = true;
			this.lbDayOfWeek.Location = new System.Drawing.Point(13, 39);
			this.lbDayOfWeek.Name = "lbDayOfWeek";
			this.lbDayOfWeek.Size = new System.Drawing.Size(35, 13);
			this.lbDayOfWeek.TabIndex = 1;
			this.lbDayOfWeek.Text = "label1";
			// 
			// ShowDayOfWeek
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 92);
			this.Controls.Add(this.lbDayOfWeek);
			this.Controls.Add(this.dtpDate);
			this.Name = "ShowDayOfWeek";
			this.Text = "ShowDayOfWeek";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label lbDayOfWeek;
	}
}

