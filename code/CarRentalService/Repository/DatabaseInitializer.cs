using CarRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalService.Repository
{
	public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MyDatabaseContext>
	{
		protected override void Seed(MyDatabaseContext context)
		{
			var customers = new List<Customer>
			{
				new Customer{FirstName="Emil", LastName="Ende" },
				new Customer{FirstName="Friederike", LastName="Feuermann"},
				new Customer{FirstName="Georg", LastName="Gans"},
				new Customer{FirstName="Herta", LastName="Holzapfel"}

			};

			customers.ForEach(c => context.Customers.Add(c));
			context.SaveChanges();

			var cars = new List<Car>
			{
				new Car{Model="Toyota XYZ", Price=100, TimeShouldReturn=DateTime.Today, IsAvailable=false, CustomerID=1},
				new Car{Model="Ford 123", Price=75, TimeShouldReturn=DateTime.Today, IsAvailable=false, CustomerID=2},
				new Car{Model="BMW Blaues Modell", Price=200, IsAvailable=true},
				new Car{Model="BMW Rotes Modell", Price=280, IsAvailable=true},
				new Car{Model="Bus", Price=300, IsAvailable=true}
			};

			cars.ForEach(c => context.Cars.Add(c));
			context.SaveChanges();
		}
	}
}