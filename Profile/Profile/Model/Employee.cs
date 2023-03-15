using System;
using System.Collections.Generic;
using System.Text;

namespace Profile.Models
{
    
    public class Employee
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public string Description { get; set; }
        public long NationalNo { get; set; }
        public long Phone { get; set; }
        public string CompEmail { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public long Phone2 { get; set; }
        public long Mobile { get; set; }
        public string Address2 { get; set; }
        public string City2 { get; set; }
        public string Country2 { get; set; }
    }
}
