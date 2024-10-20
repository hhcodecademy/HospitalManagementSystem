using HospitalManagementSystem.DAL.Dtos;
using HospitalManagementSystem.DAL.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BLL.Services.Interfaces
{
    public interface IGenericService<TDto, TEntity> where TEntity : BaseEntity, new()
        where TDto : BaseDto, new()
    {
        public Task<TDto> AddAsync(TDto dto);
        public Task<TDto> UpdateAsync(Guid id, TDto dto);
        public Task<TDto> GetAsync(Guid id);
        public Task<IList<TDto>> GetAllAsync();
        public Task<TDto> Remove(Guid id);
    }
}
