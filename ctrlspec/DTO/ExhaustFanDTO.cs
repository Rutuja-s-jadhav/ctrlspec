using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.DTO
{
    public class ExhaustFanDTO
    {
       public double EquipmentID {get;set;}
        public string DamperControl {get; set;}
         public string RunConditions{get;set;}
      
       public string Fan {get;set;}
      
       public string FilterMonitoring{get;set;}
             public string MiscMonitoring{get;set;}
    }
}