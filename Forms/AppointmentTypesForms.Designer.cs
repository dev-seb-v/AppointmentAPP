﻿
namespace DB_Project_C969.Forms
{
	partial class AppointmentTypesForms
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
			this.appointmentBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.reportButton = new System.Windows.Forms.Button();
			this.monthTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// reportText
			// 
			this.reportText.Location = new System.Drawing.Point(82, 155);
			this.reportText.Multiline = true;
			this.reportText.Name = "reportText";
			this.reportText.ReadOnly = true;
			this.reportText.Size = new System.Drawing.Size(393, 141);
			this.reportText.TabIndex = 0;
			// 
			// appointmentBox
			// 
			this.appointmentBox.FormattingEnabled = true;
			this.appointmentBox.Items.AddRange(new object[] {
            "test",
            "Scrum",
            "Presentation",
            "lunch"});
			this.appointmentBox.Location = new System.Drawing.Point(82, 107);
			this.appointmentBox.Name = "appointmentBox";
			this.appointmentBox.Size = new System.Drawing.Size(161, 21);
			this.appointmentBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Appointment Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(315, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Month";
			// 
			// reportButton
			// 
			this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportButton.Location = new System.Drawing.Point(182, 316);
			this.reportButton.Name = "reportButton";
			this.reportButton.Size = new System.Drawing.Size(214, 32);
			this.reportButton.TabIndex = 5;
			this.reportButton.Text = "Generate Report";
			this.reportButton.UseVisualStyleBackColor = true;
			this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
			// 
			// monthTextBox
			// 
			this.monthTextBox.Location = new System.Drawing.Point(319, 107);
			this.monthTextBox.Name = "monthTextBox";
			this.monthTextBox.Size = new System.Drawing.Size(100, 20);
			this.monthTextBox.TabIndex = 6;
			// 
			// AppointmentTypesForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 379);
			this.Controls.Add(this.monthTextBox);
			this.Controls.Add(this.reportButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.appointmentBox);
			this.Controls.Add(this.reportText);
			this.Name = "AppointmentTypesForms";
			this.Text = "AppointmentTypesForms";
			this.Load += new System.EventHandler(this.AppointmentTypesForms_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox reportText;
		private System.Windows.Forms.ComboBox appointmentBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button reportButton;
		private System.Windows.Forms.TextBox monthTextBox;
	}
}