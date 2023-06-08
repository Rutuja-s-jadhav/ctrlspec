using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
using Microsoft.EntityFrameworkCore;
using ctrlspec.DTO;

namespace ctrlspec.Data
{
    public class CtrlSpecDbContext: DbContext
    {
        public CtrlSpecDbContext(DbContextOptions<CtrlSpecDbContext>options):base(options)
        {

        }
        public DbSet<Project_Info> projectinfo { get; set; }
        public DbSet<Equipment> equipment { get; set; }
        public DbSet<Login> login {get;set;}
        public DbSet<Exhaust_Fan> exhaust_Fans {get;set;}
        public DbSet<Unitary_Heat> unitary_Heats {get;set;}
        public DbSet<Room_Units> room_Units {get;set;}

           public DbSet<Spec_Option> spec_Options {get; set;}

    }
}