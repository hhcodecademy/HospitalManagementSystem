using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAL.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity 
    {
        public Task AddAsync(T entity);
        public void Update(T entity);
        public Task<T> GetAsync(Guid id);
        public IQueryable<T> GetAll();
        public void Remove(T entity);
    }
}
