
namespace DB_Project_C969.Forms
{
	partial class AppointmentUpdate
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentUpdate));
			this.button2 = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.appointmentDGV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(95, 291);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 39);
			this.button2.TabIndex = 27;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// updateBtn
			// 
			this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateBtn.Location = new System.Drawing.Point(245, 291);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(110, 39);
			this.updateBtn.TabIndex = 26;
			this.updateBtn.Text = "Update";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// appointmentDGV
			// 
			this.appointmentDGV.AllowUserToAddRows = false;
			this.appointmentDGV.AllowUserToDeleteRows = false;
			this.appointmentDGV.AllowUserToResizeColumns = false;
			this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentDGV.Location = new System.Drawing.Point(44, 63);
			this.appointmentDGV.Name = "appointmentDGV";
			this.appointmentDGV.Size = new System.Drawing.Size(366, 150);
			this.appointmentDGV.TabIndex = 28;
			this.appointmentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDGV_CellClick);
			// 
			// AppointmentUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 359);
			this.Controls.Add(this.appointmentDGV);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.updateBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AppointmentUpdate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update Appointment";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentUpdate_FormClosed);
			this.Load += new System.EventHandler(this.AppointmentUpdate_Load);
			((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.DataGridView appointmentDGV;
	}
}