
namespace DB_Project_C969
{
    partial class updateCustomerForm
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
			this.custDGV = new System.Windows.Forms.DataGridView();
			this.updateCustButton = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.custDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// custDGV
			// 
			this.custDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.custDGV.Location = new System.Drawing.Point(12, 159);
			this.custDGV.Name = "custDGV";
			this.custDGV.Size = new System.Drawing.Size(392, 162);
			this.custDGV.TabIndex = 0;
			this.custDGV.TabStop = false;
			this.custDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDGV_CellClick);
			// 
			// updateCustButton
			// 
			this.updateCustButton.Location = new System.Drawing.Point(292, 119);
			this.updateCustButton.Name = "updateCustButton";
			this.updateCustButton.Size = new System.Drawing.Size(112, 34);
			this.updateCustButton.TabIndex = 1;
			this.updateCustButton.Text = "Update";
			this.updateCustButton.UseVisualStyleBackColor = true;
			this.updateCustButton.Click += new System.EventHandler(this.updateCustButton_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(12, 119);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(112, 34);
			this.CancelBtn.TabIndex = 2;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// updateCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 350);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.updateCustButton);
			this.Controls.Add(this.custDGV);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "updateCustomerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Customer";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.updateCustomerForm_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.custDGV)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView custDGV;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.Button CancelBtn;
    }
}