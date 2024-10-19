using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
   public class Recipe : BaseEntity
    {
        public int Number { get; set; }
        public string Thesis { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public string DiagnosisId { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
