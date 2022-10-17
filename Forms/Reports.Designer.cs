
namespace DB_Project_C969.Forms
{
	partial class Reports
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
			this.reportText = new System.Windows.Forms.TextBox();
			this.selectBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// reportText
			// 
			this.reportText.Location = new System.Drawing.Point(61, 175);
			this.reportText.Multiline = true;
			this.reportText.Name = "reportText";
			this.reportText.Size = new System.Drawing.Size(669, 167);
			this.reportText.TabIndex = 0;
			// 
			// selectBox
			// 
			this.selectBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectBox.FormattingEnabled = true;
			this.selectBox.Items.AddRange(new object[] {
            "Number of Meetings Per Month (By Type)",
            "User Schedules",
            "Number of Meetings By Quarter"});
			this.selectBox.Location = new System.Drawing.Point(313, 78);
			this.selectBox.Name = "selectBox";
			this.selectBox.Size = new System.Drawing.Size(213, 29);
			this.selectBox.TabIndex = 5;
			this.selectBox.SelectedValueChanged += new System.EventHandler(this.selectBox_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(350, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Choose Report Type";
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.selectBox);
			this.Controls.Add(this.reportText);
			this.Name = "Reports";
			this.Text = "Reports";
			this.Load += new System.EventHandler(this.Reports_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox reportText;
		private System.Windows.Forms.ComboBox selectBox;
		private System.Windows.Forms.Label label3;
	}
}