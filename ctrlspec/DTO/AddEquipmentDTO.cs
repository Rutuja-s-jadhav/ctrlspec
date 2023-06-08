using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.DTO
{
    public class AddEquipmentDTO
    {         
        public double ProjectNumber{get;set;}
         public double EquipmentID {get;set;}
       
       public string EquipmentType {get;set;}
       public string EquipmentName {get;set;}
       public string TypicalOf {get;set;}
      
      //  public string RunConditions{get;set;}
      
      //  public string Fan {get;set;}
      
      //  public string FilterMonitoring{get;set;}
      //        public string MiscMonitoring{get;set;}

    }
}