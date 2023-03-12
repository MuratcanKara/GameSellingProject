using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingProject.Entities
{
    public class Customer : Person
    {
        
        public string TcNo { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
