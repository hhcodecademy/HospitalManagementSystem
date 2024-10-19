using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    public class PatinetIlness
    {
        public string PatientId {  get; set; }
        public string IllnessId { get; set; }
        public Patient Patient { get; set; }
        public Illness Illness { get; set; }
    }
}
