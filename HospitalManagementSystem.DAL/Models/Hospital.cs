using HospitalManagementSystem.DAL.Configurations;
using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    [EntityTypeConfiguration(typeof(HospitalConfiguration))]
    public class Hospital : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
/*        public ICollection<Room> Room { get; set; }
        public ICollection<Doctor> Doctor { get; set; }*/

    }
}
