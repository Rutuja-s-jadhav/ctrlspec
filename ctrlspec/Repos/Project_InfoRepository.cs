using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
using ctrlspec.Data;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Repos
{
    public class Project_InfoRepository : IProject_Info
    {
        private CtrlSpecDbContext _context;
        public Project_InfoRepository(CtrlSpecDbContext context)
        {
            _context = context;
        }
        #region Add_Project_InfoAsync
        public async Task<Project_Info> Add_Project_Info(Project_Info project)
        {

            await _context.projectinfo.AddAsync(project);
            await _context.SaveChangesAsync();
            return project;


        }
        #endregion
        #region Get_Project_InfoAsync
        public async Task<Project_Info> Get_Project_Info(double projectNumber)
        {
            try
            {
                return await _context.projectinfo.FirstOrDefaultAsync(x => x.ProjectNumber == projectNumber);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}