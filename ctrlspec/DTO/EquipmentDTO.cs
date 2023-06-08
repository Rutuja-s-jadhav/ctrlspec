using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.DTO
{
   
    public class EquipmentDTO
    {
        public double ProjectNumber{get;set;}
      
       public double EquipmentID {get;set;}
       public string EquipmentType {get;set;}
       public string EquipmentName {get;set;}
       public string TypicalOf {get;set;}
       
    }
}