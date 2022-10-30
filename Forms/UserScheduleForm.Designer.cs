
namespace DB_Project_C969.Forms
{
	partial class UserScheduleForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserScheduleForm));
			this.reportText = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.userIdComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// reportText
			// 
			this.reportText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reportText.Location = new System.Drawing.Point(77, 182);
			this.reportText.Multiline = true;
			this.reportText.Name = "reportText";
			this.reportText.ReadOnly = true;
			this.reportText.Size = new System.Drawing.Size(669, 167);
			this.reportText.TabIndex = 0;
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(286, 372);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(213, 42);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// userIdComboBox
			// 
			this.userIdComboBox.FormattingEnabled = true;
			this.userIdComboBox.Location = new System.Drawing.Point(332, 155);
			this.userIdComboBox.Name = "userIdComboBox";
			this.userIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.userIdComboBox.TabIndex = 8;
			this.userIdComboBox.SelectedValueChanged += new System.EventHandler(this.userIdComboBox_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Select a user to view his/her schedule";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(269, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 37);
			this.label2.TabIndex = 10;
			this.label2.Text = "User Schedules";
			// 
			// UserScheduleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.userIdComboBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.reportText);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserScheduleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Schedules";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reports_FormClosed);
			this.Load += new System.EventHandler(this.Reports_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox reportText;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ComboBox userIdComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}