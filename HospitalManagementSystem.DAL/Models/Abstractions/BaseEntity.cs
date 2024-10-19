using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Models.BaseModels
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
