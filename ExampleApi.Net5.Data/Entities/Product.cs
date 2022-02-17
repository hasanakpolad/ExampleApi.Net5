using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApi.Net5.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
