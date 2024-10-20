using AutoMapper;
using HospitalManagementSystem.BLL.Services.Interfaces;
using HospitalManagementSystem.DAL.Dtos;
using HospitalManagementSystem.DAL.Models.BaseModels;
using HospitalManagementSystem.DAL.Repository.Interfaces;
using HospitalManagementSystem.DAL.UnitOfWork.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BLL.Services
{
    public class GenericService<TDto, TEntity> : IGenericService<TDto, TEntity> where TEntity : BaseEntity, new()
        where TDto : BaseDto,new()
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IMapper mapper, IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<TDto> AddAsync(TDto dto)
        {
            var entityToCreate = _mapper.Map<TEntity>(dto);

            await _repository.AddAsync(entityToCreate);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<TDto>(entityToCreate);
        }

        public async Task<IList<TDto>> GetAllAsync()
        {
            var query =  _repository.GetAll();
            var entities = await query.ToListAsync();
            var dtos = _mapper.Map<List<TDto>>(entities);
            return dtos;
        }

        public async Task<TDto> GetAsync(Guid id)
        {
            var entity = await _repository.GetAsync(id);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }

        public async Task<TDto> Remove(Guid id)
        {
            var entity = await _repository.GetAsync(id);
            _repository.Remove(entity);
            _unitOfWork.SaveChanges();
            return _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> UpdateAsync(Guid id, TDto dto)
        {
            var entity = await _repository.GetAsync(id);
           dto.Id = entity.Id;
          var  entityToUpdate = _mapper.Map<TEntity>(dto);
            _repository.Update(entityToUpdate);
             _unitOfWork.SaveChanges();
            var updatedDto = _mapper.Map<TDto>(entityToUpdate);

            return updatedDto;
        }
    }
}
