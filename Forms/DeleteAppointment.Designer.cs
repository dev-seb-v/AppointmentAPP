
namespace DB_Project_C969.Forms
{
	partial class DeleteAppointment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAppointment));
			this.appointmentDGV = new System.Windows.Forms.DataGridView();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// appointmentDGV
			// 
			this.appointmentDGV.AllowUserToAddRows = false;
			this.appointmentDGV.AllowUserToDeleteRows = false;
			this.appointmentDGV.AllowUserToOrderColumns = true;
			this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentDGV.Location = new System.Drawing.Point(63, 88);
			this.appointmentDGV.Name = "appointmentDGV";
			this.appointmentDGV.Size = new System.Drawing.Size(326, 150);
			this.appointmentDGV.TabIndex = 0;
			this.appointmentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDGV_CellClick);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteBtn.Location = new System.Drawing.Point(263, 267);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(126, 39);
			this.DeleteBtn.TabIndex = 1;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelBtn.Location = new System.Drawing.Point(63, 267);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(126, 39);
			this.CancelBtn.TabIndex = 2;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// DeleteAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 359);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.appointmentDGV);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DeleteAppointment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Appointment";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteAppointment_FormClosed);
			this.Load += new System.EventHandler(this.DeleteAppointment_Load);
			((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView appointmentDGV;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Button CancelBtn;
	}
}