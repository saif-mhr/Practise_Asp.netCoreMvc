using Practise_Asp.netCoreMvc.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Asp.netCoreMvc.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
