using CarRentalService.Models;
using CarRentalService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarRentalService.Controllers
{
    public class CustomerController : ApiController
    {
		static readonly ICustomerRepository repository = new CustomerRepository();

		public IEnumerable<Customer> GetAllCustomers()
		{
			return repository.GetAll();
		}
	}
}
