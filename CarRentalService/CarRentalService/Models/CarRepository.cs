using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentalService.Models
{
	public class CarRepository : ICarRepository
	{
		private List<Car> cars = new List<Car>();

		public CarRepository()
		{
			cars.Add(new Car(1, "Toyota XYZ", 20000, DateTime.Today, false, 1, new Customer(1, "Alfred Jodocus", "Quack")));
			cars.Add(new Car(2, "Golf 12.95", 12000, null, true, null, null));
			cars.Add(new Car(3, "BMW Blaues Modell", 50000, DateTime.Now, false, 3, new Customer(3, "Gundel", "Gaukelei")));
		}

		public Car Get(int id)
		{
			return cars.Find(car => car.ID == id);
		}

		public IEnumerable<Car> GetAll()
		{
			return cars;
		}

		public bool Update(Car car)
		{
			if (car==null)
			{
				throw new ArgumentNullException("Car cannot be null");
			}
			else
			{
				int index = cars.FindIndex(c => c.ID == car.ID);
				if (index == -1) { return false; }
				cars.RemoveAt(index);
				cars.Add(car);
				return true;
			}

		}
	}
}