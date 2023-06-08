using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ctrlspec.Models
{
    public class Equipment
    {
       public double ProjectNumber{get;set;}
      
    //    [JsonIgnore]
       [Key] 
     
       public double EquipmentID {get;set;}
       public string EquipmentType {get;set;}
       public string EquipmentName {get;set;}
       public string TypicalOf {get;set;}
      
    //    public string RunConditions{get;set;}
      
    //    public string Fan {get;set;}
      
    //    public string FilterMonitoring{get;set;}
    //          public string MiscMonitoring{get;set;}

        [ForeignKey("ProjectNumber")]
     
        public Project_Info projectinfo { get; set; }

    }
}