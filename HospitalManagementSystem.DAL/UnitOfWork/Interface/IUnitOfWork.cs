using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        public Task SaveChangesAsync();
        public void SaveChanges();
    }
}
