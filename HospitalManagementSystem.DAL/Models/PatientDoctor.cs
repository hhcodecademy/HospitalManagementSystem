﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models
{
    public class PatientDoctor
    {
        public string PatientId { get; set; }
        public string DoctorId { get; set;}
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
