
namespace DB_Project_C969.Forms
{
	partial class cancelBtn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cancelBtn));
			this.reportTxtBox = new System.Windows.Forms.TextBox();
			this.reportBtn = new System.Windows.Forms.Button();
			this.customerComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// reportTxtBox
			// 
			this.reportTxtBox.Location = new System.Drawing.Point(50, 169);
			this.reportTxtBox.Multiline = true;
			this.reportTxtBox.Name = "reportTxtBox";
			this.reportTxtBox.ReadOnly = true;
			this.reportTxtBox.Size = new System.Drawing.Size(412, 116);
			this.reportTxtBox.TabIndex = 0;
			// 
			// reportBtn
			// 
			this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportBtn.Location = new System.Drawing.Point(327, 304);
			this.reportBtn.Name = "reportBtn";
			this.reportBtn.Size = new System.Drawing.Size(135, 37);
			this.reportBtn.TabIndex = 1;
			this.reportBtn.Text = "Generate Report";
			this.reportBtn.UseVisualStyleBackColor = true;
			this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
			// 
			// customerComboBox
			// 
			this.customerComboBox.FormattingEnabled = true;
			this.customerComboBox.Location = new System.Drawing.Point(192, 106);
			this.customerComboBox.Name = "customerComboBox";
			this.customerComboBox.Size = new System.Drawing.Size(121, 21);
			this.customerComboBox.TabIndex = 2;
			this.customerComboBox.SelectedValueChanged += new System.EventHandler(this.customerComboBox_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(204, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Customer Info";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(50, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 37);
			this.button1.TabIndex = 4;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cancelBtn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 367);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.customerComboBox);
			this.Controls.Add(this.reportBtn);
			this.Controls.Add(this.reportTxtBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "cancelBtn";
			this.Text = "Customer Info";
			this.Load += new System.EventHandler(this.ExtraReport_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox reportTxtBox;
		private System.Windows.Forms.Button reportBtn;
		private System.Windows.Forms.ComboBox customerComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}