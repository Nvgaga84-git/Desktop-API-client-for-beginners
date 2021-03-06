using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VizsgaFeladat.Models
{
	public class Employee
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Address { get; set; }

		public DateTime BirthDate { get; set; }

		public int JobTypeId { get; set; }

	}
}
