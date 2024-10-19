using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    public class Room : BaseEntity
    {
        public int Number {  get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public Hospital Hospital { get; set; }
        public string HospitalId { get; set; }  
    }
}
