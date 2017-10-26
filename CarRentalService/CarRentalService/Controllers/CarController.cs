using CarRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarRentalService.Controllers
{
    public class CarController : ApiController
    {
		static readonly ICarRepository repository = new CarRepository();

		public IEnumerable<Car> GetAllCars()
		{
			return repository.GetAll();
		}

		public Car GetCar(int id)
		{
			Car car = repository.Get(id);
			if (car == null) { throw new HttpResponseException(HttpStatusCode.NotFound); }
			return car;
		}

		public void PutCar(int id, Car car)
		{
			car.ID = id;
			if (!repository.Update(car))
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}
		}
    }
}
