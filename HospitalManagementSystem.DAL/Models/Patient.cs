using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    public class Patient :Person
    {
       public string Complaint {  get; set; }   
        public string  Address { get; set; }
        public Recipe Recipe { get; set; }
        public string RecipeId { get; set; }
    }
}
