namespace Vizsgafeladat
{
	partial class JobTypesForm
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
			this.dgvJobTypes = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSaveJobType = new System.Windows.Forms.Button();
			this.txtJobType = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvJobTypes)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvJobTypes
			// 
			this.dgvJobTypes.AllowUserToAddRows = false;
			this.dgvJobTypes.AllowUserToDeleteRows = false;
			this.dgvJobTypes.AllowUserToResizeColumns = false;
			this.dgvJobTypes.AllowUserToResizeRows = false;
			this.dgvJobTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvJobTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvJobTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
			this.dgvJobTypes.Location = new System.Drawing.Point(12, 12);
			this.dgvJobTypes.Name = "dgvJobTypes";
			this.dgvJobTypes.ReadOnly = true;
			this.dgvJobTypes.RowHeadersVisible = false;
			this.dgvJobTypes.RowTemplate.Height = 25;
			this.dgvJobTypes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvJobTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvJobTypes.Size = new System.Drawing.Size(334, 223);
			this.dgvJobTypes.TabIndex = 0;
			// 
			// colID
			// 
			this.colID.FillWeight = 50.76142F;
			this.colID.HeaderText = "ID";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			// 
			// colName
			// 
			this.colName.FillWeight = 149.2386F;
			this.colName.HeaderText = "Munkakör";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSaveJobType);
			this.panel1.Controls.Add(this.txtJobType);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 241);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(334, 106);
			this.panel1.TabIndex = 1;
			// 
			// btnSaveJobType
			// 
			this.btnSaveJobType.Location = new System.Drawing.Point(24, 70);
			this.btnSaveJobType.Name = "btnSaveJobType";
			this.btnSaveJobType.Size = new System.Drawing.Size(75, 23);
			this.btnSaveJobType.TabIndex = 2;
			this.btnSaveJobType.Text = "Mentés";
			this.btnSaveJobType.UseVisualStyleBackColor = true;
			this.btnSaveJobType.Click += new System.EventHandler(this.btnSaveJobType_Click);
			// 
			// txtJobType
			// 
			this.txtJobType.Location = new System.Drawing.Point(24, 41);
			this.txtJobType.Name = "txtJobType";
			this.txtJobType.PlaceholderText = "Munkakör megnevezés";
			this.txtJobType.Size = new System.Drawing.Size(285, 23);
			this.txtJobType.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(113, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Új munkakör";
			// 
			// JobTypesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 357);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvJobTypes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "JobTypesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "JobTypesForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvJobTypes)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvJobTypes;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSaveJobType;
		private System.Windows.Forms.TextBox txtJobType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
	}
}