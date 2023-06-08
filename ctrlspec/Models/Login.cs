using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.Models
{
    public class Login
    {
        [Key]
        public double LoginId {get; set;}
        public string Name {get; set;}
        public string EmailId {get; set;}
        public string Password {get; set;}
    }
}