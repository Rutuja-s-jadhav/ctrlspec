using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Models
{
    
    public class Unitary_Heat
    {
         [Key]
        public double EquipmentID {get; set;}

        public string ZoneControl {get; set;}
        public string Heating {get; set;}
        public string EnvironmentalIndex {get; set;}
        
       public string RunConditions{get;set;}
      
       public string Fan {get;set;}
      
       public string FilterMonitoring{get;set;}
             public string MiscMonitoring{get;set;}
        [ForeignKey("EquipmentID")]
        public Equipment equipment { get; set; }
        
    }
}