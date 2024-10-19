using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    public class Illness : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
    }
}
