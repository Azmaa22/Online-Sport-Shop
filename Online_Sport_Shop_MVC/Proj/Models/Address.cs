using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public Address(string country, string city, string street)
        {
            City = city;
            Country = country;
            Street = street;
        }

    }
}
