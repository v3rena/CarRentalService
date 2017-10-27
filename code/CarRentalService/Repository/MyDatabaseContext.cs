using CarRentalService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarRentalService.Repository
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext() : base("name=MyDbConnection")
        {
        }
        
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Car> Cars { get; set; }
	}
}
