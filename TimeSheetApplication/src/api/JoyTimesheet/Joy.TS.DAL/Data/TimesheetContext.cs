using Employee.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Joy.TS.DAL.Data
{
     public class TimesheetContext:DbContext
    {

        public TimesheetContext(DbContextOptions<TimesheetContext> options) : base(options)
        {

        }
        public DbSet<Employeetype> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Employee_Project> Employee_Projects { get; set; }
        public DbSet<Timesheet_Summary> Timesheet_Summarys { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
    }
}
