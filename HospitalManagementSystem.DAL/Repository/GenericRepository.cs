using HospitalManagementSystem.DAL.Data;
using HospitalManagementSystem.DAL.Models.BaseModels;
using HospitalManagementSystem.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace HospitalManagementSystem.DAL.Repository;
public class GenericRepository<T>(AppDbContext _dbContext) : IGenericRepository<T> where T : BaseEntity
{
    private readonly DbSet<T> _dbSet = _dbContext.Set<T>();
    public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);
    public async Task<T> GetAsync(Guid id) => await _dbSet.FindAsync(id);
    public IQueryable<T> GetAll() => _dbSet.AsQueryable().AsNoTracking();
    public void Remove(T entity)=> _dbSet.Remove(entity);
    public void Update(T entity) => _dbSet.Update(entity);
}
