using System.Collections.Generic;
using System.Linq;

namespace ApiPractical.Entities
{
    public class CustomerRepository
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(){FirstName = "Olajide",LastName="Qahar", Email = "abdulqaharolajide@gmail.com"},
            new Customer(){FirstName = "Adebisi",LastName="Qaharo", Email = "abdulqaharode@gmail.com"},
            new Customer(){FirstName = "Adebayi",LastName="Qaharu", Email = "abdulqalajide@gmail.com"},
            new Customer(){FirstName = "Olaluo",LastName="Qahare", Email = "abdulqahajide@gmail.com"},
            new Customer(){FirstName = "Hounart",LastName="Qahari", Email = "abdharolajide@gmail.com"},


        };
        public Customer GetCustomerByFirstName(string firstname)
        {
            var customer = customers.Where(x => x.FirstName.Equals(firstname)).SingleOrDefault();
            return customer;
        }
        public List<Customer> GetAllCustomers()
        {
            var customer = customers.ToList();
            return customer;
        }
        public List<Customer> GetNameByLetter(string a)
        {
            var customer = customers.FindAll(x => x.FirstName.Contains(a)).ToList();

            return customer;



        }
    }
}
