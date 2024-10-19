using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models.BaseModels
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }   
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
