using GameSellingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Abstracts
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
        void IfCustomerRealPerson(string tcNo, string personName, string personLastName, DateTime dateOfBirth);
    }
}
