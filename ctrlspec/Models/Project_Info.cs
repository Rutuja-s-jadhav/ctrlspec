using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ctrlspec.Models
{
    public class Project_Info
    {
     public string MeasurementType {get;set;}

     [Key]
     public double ProjectNumber {get;set;}
     public string ProjectName {get; set;}
     public string PreparedBy {get; set;}

    
    }

}