using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalService.Models
{
	public class Car
	{
		public Car() { }

		public Car(int ID, string Model, float Price, DateTime? TimeShouldReturn, bool IsAvailable, int? CustomerID, Customer Customer)
		{
			this.ID = ID;
			this.Model = Model;
			this.Price = Price;
			this.TimeShouldReturn = TimeShouldReturn;
			this.IsAvailable = IsAvailable;
			this.CustomerID = CustomerID;
			this.Customer = Customer;
		}

		public int ID { get; set; }
		public string Model { get; set; }
		public float Price { get; set; }
		public DateTime? TimeShouldReturn { get; set; }
		public bool IsAvailable { get; set; }
		public int? CustomerID { get; set; }
		public virtual Customer Customer { get; set; }
	}
}