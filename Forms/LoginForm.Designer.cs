
namespace DB_Project_C969
{
	partial class LoginForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.submitButton = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.submitButton);
			this.panel1.Controls.Add(this.passwordTextBox);
			this.panel1.Controls.Add(this.usernameTextBox);
			this.panel1.Controls.Add(this.passwordLabel);
			this.panel1.Controls.Add(this.usernameLabel);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(436, 284);
			this.panel1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(82, 171);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 41);
			this.button2.TabIndex = 6;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// submitButton
			// 
			this.submitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.Location = new System.Drawing.Point(241, 171);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(103, 41);
			this.submitButton.TabIndex = 5;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(191, 122);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(153, 20);
			this.passwordTextBox.TabIndex = 4;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(191, 76);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(153, 20);
			this.usernameTextBox.TabIndex = 3;
			this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLabel.Location = new System.Drawing.Point(78, 120);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(70, 20);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "Password";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameLabel.Location = new System.Drawing.Point(78, 76);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(75, 20);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "Username";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 324);
			this.Controls.Add(this.panel1);
			this.Name = "LoginForm";
			this.Text = "LOGIN";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label usernameLabel;
    }
}