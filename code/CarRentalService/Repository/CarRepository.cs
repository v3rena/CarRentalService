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
			List<Car> list = db.Cars.ToList();


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
				/*Car localCar = db.Cars.Find(car.ID);
				db.Cars.Remove(localCar);
				db.Cars.Add(localCar);
				db.SaveChanges();
				return true;*/

				/*var cars = db.Cars.ToList();
				int index = cars.FindIndex(c => c.ID == car.ID);
				if (index == -1) { return false; }
				cars.RemoveAt(index);*/

				/*Car localCar = db.Cars.Find(car.ID);
				db.SaveChanges();
				return true;*/

				var result = db.Cars.SingleOrDefault(b => b.ID == car.ID);
				if (result != null)
				{
					result.CustomerID = car.CustomerID;
					result.Customer = car.Customer;
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