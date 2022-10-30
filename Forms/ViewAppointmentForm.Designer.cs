
namespace DB_Project_C969.Forms
{
	partial class ViewAppointmentForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointmentForm));
			this.label1 = new System.Windows.Forms.Label();
			this.allRB = new System.Windows.Forms.RadioButton();
			this.weekRB = new System.Windows.Forms.RadioButton();
			this.monthRB = new System.Windows.Forms.RadioButton();
			this.DGV_UTC = new System.Windows.Forms.DataGridView();
			this.DGV_LOCAL = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DGV_UTC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_LOCAL)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
			this.label1.Location = new System.Drawing.Point(294, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "View Appointment";
			// 
			// allRB
			// 
			this.allRB.AutoSize = true;
			this.allRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allRB.Location = new System.Drawing.Point(215, 375);
			this.allRB.Name = "allRB";
			this.allRB.Size = new System.Drawing.Size(148, 25);
			this.allRB.TabIndex = 1;
			this.allRB.TabStop = true;
			this.allRB.Text = "All Appointments";
			this.allRB.UseVisualStyleBackColor = true;
			this.allRB.CheckedChanged += new System.EventHandler(this.allRB_CheckedChanged);
			// 
			// weekRB
			// 
			this.weekRB.AutoSize = true;
			this.weekRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weekRB.Location = new System.Drawing.Point(387, 375);
			this.weekRB.Name = "weekRB";
			this.weekRB.Size = new System.Drawing.Size(123, 25);
			this.weekRB.TabIndex = 2;
			this.weekRB.TabStop = true;
			this.weekRB.Text = "Current Week";
			this.weekRB.UseVisualStyleBackColor = true;
			this.weekRB.CheckedChanged += new System.EventHandler(this.weekRB_CheckedChanged);
			// 
			// monthRB
			// 
			this.monthRB.AutoSize = true;
			this.monthRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthRB.Location = new System.Drawing.Point(542, 375);
			this.monthRB.Name = "monthRB";
			this.monthRB.Size = new System.Drawing.Size(131, 25);
			this.monthRB.TabIndex = 3;
			this.monthRB.TabStop = true;
			this.monthRB.Text = "Current Month";
			this.monthRB.UseVisualStyleBackColor = true;
			this.monthRB.CheckedChanged += new System.EventHandler(this.monthRB_CheckedChanged);
			// 
			// DGV_UTC
			// 
			this.DGV_UTC.AllowUserToAddRows = false;
			this.DGV_UTC.AllowUserToDeleteRows = false;
			this.DGV_UTC.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGV_UTC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DGV_UTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_UTC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.DGV_UTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_UTC.Location = new System.Drawing.Point(61, 50);
			this.DGV_UTC.Name = "DGV_UTC";
			this.DGV_UTC.ReadOnly = true;
			this.DGV_UTC.Size = new System.Drawing.Size(612, 134);
			this.DGV_UTC.TabIndex = 4;
			// 
			// DGV_LOCAL
			// 
			this.DGV_LOCAL.AllowUserToAddRows = false;
			this.DGV_LOCAL.AllowUserToDeleteRows = false;
			this.DGV_LOCAL.AllowUserToResizeColumns = false;
			this.DGV_LOCAL.AllowUserToResizeRows = false;
			this.DGV_LOCAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_LOCAL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.DGV_LOCAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_LOCAL.Location = new System.Drawing.Point(61, 211);
			this.DGV_LOCAL.Name = "DGV_LOCAL";
			this.DGV_LOCAL.ReadOnly = true;
			this.DGV_LOCAL.Size = new System.Drawing.Size(612, 130);
			this.DGV_LOCAL.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "UTC";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "LOCAL";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(61, 364);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 46);
			this.button1.TabIndex = 8;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ViewAppointmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 432);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DGV_LOCAL);
			this.Controls.Add(this.DGV_UTC);
			this.Controls.Add(this.monthRB);
			this.Controls.Add(this.weekRB);
			this.Controls.Add(this.allRB);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ViewAppointmentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Appointments";
			this.Load += new System.EventHandler(this.ViewAppointmentForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_UTC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_LOCAL)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton allRB;
		private System.Windows.Forms.RadioButton weekRB;
		private System.Windows.Forms.RadioButton monthRB;
		private System.Windows.Forms.DataGridView DGV_UTC;
		private System.Windows.Forms.DataGridView DGV_LOCAL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}