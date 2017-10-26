using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalService.Models
{
	public class Customer
	{
		public Customer() { }

		public Customer(int ID, string FirstName, string LastName)
		{
			this.ID = ID;
			this.FirstName = FirstName;
			this.LastName = LastName;
		}

		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}