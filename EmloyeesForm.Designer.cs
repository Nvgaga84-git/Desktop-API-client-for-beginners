
namespace Vizsgafeladat
{
	partial class EmloyeesForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnJobTypes = new System.Windows.Forms.Button();
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colJobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnUj = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// btnJobTypes
			// 
			this.btnJobTypes.Location = new System.Drawing.Point(106, 415);
			this.btnJobTypes.Name = "btnJobTypes";
			this.btnJobTypes.Size = new System.Drawing.Size(88, 23);
			this.btnJobTypes.TabIndex = 0;
			this.btnJobTypes.Text = "Munkakörök";
			this.btnJobTypes.UseVisualStyleBackColor = true;
			this.btnJobTypes.Click += new System.EventHandler(this.button1_Click);
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.AllowUserToAddRows = false;
			this.dgvEmployees.AllowUserToDeleteRows = false;
			this.dgvEmployees.AllowUserToResizeColumns = false;
			this.dgvEmployees.AllowUserToResizeRows = false;
			this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colName,
            this.colAddress,
            this.colBirthDate,
            this.colJobType});
			this.dgvEmployees.Location = new System.Drawing.Point(12, 39);
			this.dgvEmployees.MultiSelect = false;
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.ReadOnly = true;
			this.dgvEmployees.RowHeadersVisible = false;
			this.dgvEmployees.RowTemplate.Height = 25;
			this.dgvEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployees.Size = new System.Drawing.Size(776, 370);
			this.dgvEmployees.TabIndex = 1;
			// 
			// ID
			// 
			this.ID.FillWeight = 15.83819F;
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ID.Width = 43;
			// 
			// colName
			// 
			this.colName.FillWeight = 449.2386F;
			this.colName.HeaderText = "Név";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colName.Width = 53;
			// 
			// colAddress
			// 
			this.colAddress.FillWeight = 11.64107F;
			this.colAddress.HeaderText = "Lakcím";
			this.colAddress.Name = "colAddress";
			this.colAddress.ReadOnly = true;
			this.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colAddress.Width = 70;
			// 
			// colBirthDate
			// 
			this.colBirthDate.FillWeight = 11.64107F;
			this.colBirthDate.HeaderText = "Születési dátum";
			this.colBirthDate.Name = "colBirthDate";
			this.colBirthDate.ReadOnly = true;
			this.colBirthDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colBirthDate.Width = 115;
			// 
			// colJobType
			// 
			this.colJobType.FillWeight = 11.64107F;
			this.colJobType.HeaderText = "Munkakör";
			this.colJobType.Name = "colJobType";
			this.colJobType.ReadOnly = true;
			this.colJobType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colJobType.Width = 86;
			// 
			// btnUj
			// 
			this.btnUj.Location = new System.Drawing.Point(12, 415);
			this.btnUj.Name = "btnUj";
			this.btnUj.Size = new System.Drawing.Size(88, 23);
			this.btnUj.TabIndex = 2;
			this.btnUj.Text = "Új személy";
			this.btnUj.UseVisualStyleBackColor = true;
			this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(200, 415);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(88, 23);
			this.btnExport.TabIndex = 3;
			this.btnExport.Text = "Exportálás";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// EmloyeesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.btnUj);
			this.Controls.Add(this.dgvEmployees);
			this.Controls.Add(this.btnJobTypes);
			this.Name = "EmloyeesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Személyek";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnJobTypes;
		private System.Windows.Forms.DataGridView dgvEmployees;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJobType;
		private System.Windows.Forms.Button btnUj;
		private System.Windows.Forms.Button btnExport;
	}
}

