using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.DTO
{
    public class Spec_OptionDTO
    {
     
        [Key]
        public double Id {get;set;}
        public string Questions {get; set;}
        // public string Status {get; set;}
        
    }
}