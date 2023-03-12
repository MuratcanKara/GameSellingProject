using GameSellingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Abstracts
{
    public interface ICustomerService
    {
        void CreateAcc(Customer customer);
        void DeleteAcc(Customer customer);
        void UpdateAcc(Customer customer);
    }
}
