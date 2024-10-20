using HospitalManagementSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Hospital> Hospitals { get; set; }
        /*  public DbSet<Doctor> Doctors { get; set; }
          public DbSet<Diagnosis> Diagnosis { get; set; }*/
        /*     public DbSet<Illness> Illnesses { get; set; }
             public DbSet<Patient> Patients { get; set; }
             public DbSet<Recipe> Recipes { get; set; }
             public DbSet<Room> Rooms { get; set; }
             public DbSet<PatientDoctor> PatientDoctors { get;set; }
             public DbSet<PatinetIlness> PatientIlness { get; set; }*/


    }
}
