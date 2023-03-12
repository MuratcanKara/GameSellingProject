using GameSellingProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Concretes
{
    public class BlizzardCustomerManager : BaseCustomerManager
    {
        public ICustomerCheckService customerCheckService1;
        public BlizzardCustomerManager(ICustomerCheckService customerCheckService)
        {
            customerCheckService1= customerCheckService;
        }
    }
}
