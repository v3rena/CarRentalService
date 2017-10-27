using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRentalService.Models;

namespace CarRentalService.Repository
{
	public class CarRepository : ICarRepository
	{
		private MyDatabaseContext db = new MyDatabaseContext();

		public CarRepository()
		{ }

		public Car Get(int id)
		{
			return db.Cars.Find(id);
		}

		public IEnumerable<Car> GetAll()
		{
			return db.Cars.ToList();
		}

		public bool Update(Car car)
		{
			if (car==null)
			{
				throw new ArgumentNullException("Car cannot be null");
			}
			else
			{
				var result = db.Cars.SingleOrDefault(b => b.ID == car.ID);
				if (result != null)
				{
					result.CustomerID = car.CustomerID;
					//result.Customer = car.Customer;
					result.IsAvailable = car.IsAvailable;
					result.Model = car.Model;
					result.Price = car.Price;
					result.TimeShouldReturn = car.TimeShouldReturn;
					db.SaveChanges();
					return true;
				}
				return false;
			}
		}

		public void AddCar(Car car)
		{
			db.Cars.Add(car);
		}
	}
}