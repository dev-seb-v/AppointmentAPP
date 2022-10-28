
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
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
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// button2
			// 
			resources.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// submitButton
			// 
			resources.ApplyResources(this.submitButton, "submitButton");
			this.submitButton.Name = "submitButton";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// passwordTextBox
			// 
			resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
			// 
			// usernameTextBox
			// 
			resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
			// 
			// passwordLabel
			// 
			resources.ApplyResources(this.passwordLabel, "passwordLabel");
			this.passwordLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.passwordLabel.Name = "passwordLabel";
			// 
			// usernameLabel
			// 
			resources.ApplyResources(this.usernameLabel, "usernameLabel");
			this.usernameLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.usernameLabel.Name = "usernameLabel";
			// 
			// LoginForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "LoginForm";
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