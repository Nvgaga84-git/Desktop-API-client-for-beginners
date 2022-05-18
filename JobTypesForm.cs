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
	public partial class JobTypesForm : Form
	{
		public JobTypesForm()
		{
			InitializeComponent();
			_RefreshJobTypes();
		}

		private async Task _RefreshJobTypes()
		{
			List<JobType> jobtypes;
			using (Network net = new Network())
			{
				jobtypes = await net.GetAsync<List<JobType>>($"Data/getjobtypes");
			}
			dgvJobTypes.Rows.Clear();
			foreach (JobType jobtype in jobtypes)
			{
				dgvJobTypes.Rows.Add(jobtype.Id.ToString(), jobtype.Name);
			}
		}

		private async void btnSaveJobType_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtJobType.Text))
			{
				MessageBox.Show("A munkarkör megnevezése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.txtJobType.Focus();
			}
			using (Network net = new Network())
			{
				try
				{
					await net.PostAsync<JobType>("Data/addjobtype", new JobType()
					{
						Name = txtJobType.Text
					});
					MessageBox.Show("A tétel rögzítése megtörtént!", "Sikeres művelet", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_RefreshJobTypes();
					txtJobType.Clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"A tétel rögzítése sikertelen! Hiba: {ex.Message}", "Sikertele művelet", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
