using CarRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalService.Repository
{
	public class CustomerRepository : ICustomerRepository
	{
		private MyDatabaseContext db = new MyDatabaseContext();

		public CustomerRepository() { }

		public IEnumerable<Customer> GetAll()
		{
			return db.Customers.ToList();
		}

		public void AddCustomer(Customer customer)
		{
			db.Customers.Add(customer);
			db.SaveChanges();
		}
	}
}