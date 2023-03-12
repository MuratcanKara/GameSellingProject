using GameSellingProject.Abstracts;
using GameSellingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameSellingProject.Concretes
{
    public class CustomerCheckManager : ICustomerCheckService
    {

        

        public CustomerCheckManager()
        {
            
        }

        
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

        public void IfCustomerRealPerson(string tcNo, string personName, string personLastName, DateTime dateOfBirth)
        {
            Customer customer = new Customer { TcNo = tcNo, PersonName = personName, PersonLastName = personLastName, DateOfBirth = dateOfBirth };
            bool isRealPerson = CheckIfRealPerson(customer);
            if (isRealPerson == true)
            {
                Console.WriteLine("The customer is a real person.");
            }
            else
            {
                Console.WriteLine("The customer is not a real person.");
            }
        }
        
        
    }
}
