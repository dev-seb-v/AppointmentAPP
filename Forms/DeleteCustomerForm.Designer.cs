
namespace DB_Project_C969
{
    partial class DeleteCustomerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomerForm));
			this.CancelBtn = new System.Windows.Forms.Button();
			this.deleteCustomerBtn = new System.Windows.Forms.Button();
			this.custDGV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.custDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(12, 123);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(112, 34);
			this.CancelBtn.TabIndex = 5;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// deleteCustomerBtn
			// 
			this.deleteCustomerBtn.Location = new System.Drawing.Point(292, 123);
			this.deleteCustomerBtn.Name = "deleteCustomerBtn";
			this.deleteCustomerBtn.Size = new System.Drawing.Size(112, 34);
			this.deleteCustomerBtn.TabIndex = 4;
			this.deleteCustomerBtn.Text = "Delete";
			this.deleteCustomerBtn.UseVisualStyleBackColor = true;
			this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
			// 
			// custDGV
			// 
			this.custDGV.AllowUserToAddRows = false;
			this.custDGV.AllowUserToDeleteRows = false;
			this.custDGV.AllowUserToOrderColumns = true;
			this.custDGV.AllowUserToResizeColumns = false;
			this.custDGV.AllowUserToResizeRows = false;
			this.custDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.custDGV.Location = new System.Drawing.Point(12, 163);
			this.custDGV.Name = "custDGV";
			this.custDGV.Size = new System.Drawing.Size(392, 162);
			this.custDGV.TabIndex = 3;
			this.custDGV.TabStop = false;
			this.custDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDGV_CellClick);
			// 
			// DeleteCustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 350);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.deleteCustomerBtn);
			this.Controls.Add(this.custDGV);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DeleteCustomerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Customer ";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteCustomerForm_FormClosed);
			this.Load += new System.EventHandler(this.DeleteCustomerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.custDGV)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.DataGridView custDGV;
    }
}