using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Models
{
  
    public class Spec_Option
    {
        [Key]
        public double Id {get;set;}
        public string Questions {get; set;}
        public string Status {get; set;}
    }
}