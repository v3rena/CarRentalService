using CarRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalService.Repository
{
	public interface ICarRepository
	{
		IEnumerable<Car> GetAll();
		Car Get(int id);
		bool Update(Car car);
	}
}
