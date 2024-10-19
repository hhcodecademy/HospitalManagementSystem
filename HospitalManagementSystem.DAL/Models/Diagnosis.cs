using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    public class Diagnosis : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Recipe Recipe { get; set; }
        public string RecipeId { get; set; }
        public string DoctorId { get; set; }
        public string PatientId { get; set; }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
