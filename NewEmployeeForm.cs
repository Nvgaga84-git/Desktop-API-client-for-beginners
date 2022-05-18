using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VizsgaFeladat.Models;

namespace Vizsgafeladat
{
	public partial class NewEmployeeForm : Form
	{
		public NewEmployeeForm()
		{
			InitializeComponent();
		}

		private async Task _LoadJobTypes()
		{
			List<JobType> jobtypes;
			using (Network net = new Network())
			{
				jobtypes = await net.GetAsync<List<JobType>>($"Data/getjobtypes");
			}
			foreach (JobType jobtype in jobtypes)
			{
				cbJobType.Items.Add(jobtype);
			}
			this.cbJobType.SelectedIndex = 0;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			Employee employee = new Employee()
			{
				Name = this.txtName.Text,
				Address = this.txtAddress.Text,
				BirthDate = this.dateBirth.Value,
				JobTypeId = ((JobType)this.cbJobType.SelectedItem).Id
			};
			using (Network net = new Network())
			{
				try
				{
					await net.PostAsync<Employee>("Data/addnewemployee", employee);
					MessageBox.Show("A személy rögzítésre került!","Sikeres művelet",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void NewEmployeeForm_Load(object sender, EventArgs e)
		{
			_LoadJobTypes().GetAwaiter();
		}
	}
}
