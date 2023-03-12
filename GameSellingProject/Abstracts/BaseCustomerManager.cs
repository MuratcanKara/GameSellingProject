using GameSellingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Abstracts
{
    public class BaseCustomerManager : ICustomerService
    {

        public void CreateAcc(Customer customer)
        {
            Console.WriteLine("Customer with that name : " + customer.PersonName + "has created!");
        }

        public void DeleteAcc(Customer customer)
        {
            Console.WriteLine("Customer with that name : " + customer.PersonName + "has deleted!");
        }

        public void UpdateAcc(Customer customer)
        {
            Console.WriteLine("Customer with that name : " + customer.PersonName + "has updated!");
        }
    }
}
