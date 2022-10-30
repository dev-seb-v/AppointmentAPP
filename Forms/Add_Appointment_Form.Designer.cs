
namespace DB_Project_C969
{
    partial class Add_Appointment_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Appointment_Form));
			this.AddAppBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.userIdComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.customerComboBox = new System.Windows.Forms.ComboBox();
			this.typeTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.end = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AddAppBtn
			// 
			this.AddAppBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddAppBtn.Location = new System.Drawing.Point(225, 276);
			this.AddAppBtn.Name = "AddAppBtn";
			this.AddAppBtn.Size = new System.Drawing.Size(110, 39);
			this.AddAppBtn.TabIndex = 9;
			this.AddAppBtn.Text = "Add";
			this.AddAppBtn.UseVisualStyleBackColor = true;
			this.AddAppBtn.Click += new System.EventHandler(this.AddAppBtn_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(57, 276);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 39);
			this.button2.TabIndex = 10;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// userIdComboBox
			// 
			this.userIdComboBox.FormattingEnabled = true;
			this.userIdComboBox.Location = new System.Drawing.Point(57, 36);
			this.userIdComboBox.Name = "userIdComboBox";
			this.userIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.userIdComboBox.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(121, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "User ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(106, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "Customer";
			// 
			// customerComboBox
			// 
			this.customerComboBox.FormattingEnabled = true;
			this.customerComboBox.Location = new System.Drawing.Point(57, 104);
			this.customerComboBox.Name = "customerComboBox";
			this.customerComboBox.Size = new System.Drawing.Size(121, 21);
			this.customerComboBox.TabIndex = 14;
			// 
			// typeTextBox
			// 
			this.typeTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.typeTextBox.Location = new System.Drawing.Point(225, 36);
			this.typeTextBox.Multiline = true;
			this.typeTextBox.Name = "typeTextBox";
			this.typeTextBox.Size = new System.Drawing.Size(155, 25);
			this.typeTextBox.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(230, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Type of Appointment";
			// 
			// start
			// 
			this.start.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start.Location = new System.Drawing.Point(57, 158);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(368, 25);
			this.start.TabIndex = 19;
			this.start.ValueChanged += new System.EventHandler(this.start_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(311, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 17);
			this.label5.TabIndex = 23;
			this.label5.Text = "Appointment Start";
			// 
			// end
			// 
			this.end.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.end.Location = new System.Drawing.Point(57, 217);
			this.end.Name = "end";
			this.end.Size = new System.Drawing.Size(368, 25);
			this.end.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(316, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "Appointment End";
			// 
			// Add_Appointment_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 359);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.end);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.start);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.typeTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.customerComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.userIdComboBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.AddAppBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Add_Appointment_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Appointment";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Appointment_Form_FormClosed);
			this.Load += new System.EventHandler(this.Add_Appointment_Form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddAppBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox userIdComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker start;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker end;
		private System.Windows.Forms.Label label4;
	}
}