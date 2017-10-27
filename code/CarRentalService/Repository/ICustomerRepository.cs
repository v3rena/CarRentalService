using CarRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalService.Repository
{
	interface ICustomerRepository
	{
		IEnumerable<Customer> GetAll();
	}
}
