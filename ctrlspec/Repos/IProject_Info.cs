using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;


namespace ctrlspec.Repos
{
    public interface IProject_Info
    {
        Task<Project_Info> Add_Project_Info(Project_Info project);
        Task<Project_Info> Get_Project_Info(double projectNumber);

    }
}