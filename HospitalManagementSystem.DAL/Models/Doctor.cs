using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    public class Doctor :Person
    {
public string Title { get; set; }
        public string Position { get; set; }
        public Hospital Hospital { get; set; }
        public string HospitalId { get; set; }  
        public ICollection<Diagnosis> Diagnosis { get; set; }
        public Recipe Recipe { get; set; }
        public string RecipeId { get; set; }
        
    }
}
