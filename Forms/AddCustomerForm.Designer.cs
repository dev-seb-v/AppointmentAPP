
namespace DB_Project_C969
{
    partial class AddCustomerForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
			this.label5 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
			this.addCustomerButton = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(197, -19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Country";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(128, 29);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(205, 20);
			this.nameTextBox.TabIndex = 0;
			this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(128, 73);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(205, 20);
			this.addressTextBox.TabIndex = 1;
			this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(128, 125);
			this.phoneTextBox.Mask = "000-0000";
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(205, 20);
			this.phoneTextBox.TabIndex = 2;
			this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
			// 
			// addCustomerButton
			// 
			this.addCustomerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.addCustomerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCustomerButton.Location = new System.Drawing.Point(225, 280);
			this.addCustomerButton.Name = "addCustomerButton";
			this.addCustomerButton.Size = new System.Drawing.Size(147, 34);
			this.addCustomerButton.TabIndex = 5;
			this.addCustomerButton.Text = "Add Customer";
			this.addCustomerButton.UseVisualStyleBackColor = false;
			this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.Location = new System.Drawing.Point(81, 280);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(122, 34);
			this.cancelBtn.TabIndex = 6;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = false;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Address";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Phone No.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "City";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(38, 222);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Country";
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(128, 175);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(205, 20);
			this.cityTextBox.TabIndex = 3;
			this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
			// 
			// countryTextBox
			// 
			this.countryTextBox.Location = new System.Drawing.Point(128, 224);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(205, 20);
			this.countryTextBox.TabIndex = 4;
			this.countryTextBox.TextChanged += new System.EventHandler(this.countryTextBox_TextChanged);
			// 
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// AddCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(440, 326);
			this.Controls.Add(this.countryTextBox);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.addCustomerButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.phoneTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddCustomerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Customer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomerForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.ErrorProvider error;
    }
}