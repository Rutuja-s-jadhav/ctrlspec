using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Models
{
   
    public class Exhaust_Fan
    { 
        [Key]
        public double EquipmentID {get; set;}
        public string DamperControl {get; set;}
        
       public string RunConditions{get;set;}
      
       public string Fan {get;set;}
      
       public string FilterMonitoring{get;set;}
             public string MiscMonitoring{get;set;}
        
        [ForeignKey("EquipmentID")]
        public Equipment equipment { get; set; }

        // public static implicit operator List<object>(Exhaust_Fan v)
        // {
        //     throw new NotImplementedException();
        // }
    }
}