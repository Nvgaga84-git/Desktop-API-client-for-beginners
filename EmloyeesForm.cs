using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VizsgaFeladat.Models;

namespace Vizsgafeladat
{
	public partial class EmloyeesForm : Form
	{
		List<JobType> _jobTypes;
		public EmloyeesForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			JobTypesForm frm = new JobTypesForm();
			frm.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_RefreshJobTypes();
		}

		private async Task _RefreshJobTypes()
		{
			List<Employee> employees;

			using (Network net = new Network())
			{
				employees = await net.GetAsync<List<Employee>>($"Data/getemployees");
				this._jobTypes = await net.GetAsync<List<JobType>>($"Data/getjobtypes");
			}
			dgvEmployees.Rows.Clear();
			foreach (Employee employee in employees)
			{
				dgvEmployees.Rows.Add(employee.Id.ToString(), employee.Name, employee.Address, employee.BirthDate.ToString("yyyy-MM-dd"), _jobTypes.Single(a => a.Id == employee.JobTypeId).Name);
			}
		}

		private void btnUj_Click(object sender, EventArgs e)
		{
			NewEmployeeForm frm = new NewEmployeeForm();
			frm.ShowDialog();
			_RefreshJobTypes().GetAwaiter();
		}

		private async void btnExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "CSV file|*.csv|All files|*.*";
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.ShowDialog();
			if (string.IsNullOrEmpty(saveFileDialog.FileName))
			{
				MessageBox.Show("Nem lett célfájl beállítva!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("ID;Név;Lakcím;Születési dátum;Munkakör");
			foreach (DataGridViewRow row in dgvEmployees.Rows)
			{
				sb.AppendLine($"{row.Cells[0].Value.ToString()};{row.Cells[1].Value.ToString()};{row.Cells[2].Value.ToString()};{row.Cells[3].Value.ToString()};{row.Cells[4].Value.ToString()}");
			}
			await File.WriteAllTextAsync(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
			MessageBox.Show("A személyek exportálása sikeresen megtörtént!", "Sikeres művelet", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
