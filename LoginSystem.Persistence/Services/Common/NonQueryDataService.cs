using LoginSystem.Domain;
using LoginSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Persistence.Services.Common
{
    public class NonQueryDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly LoginDbContext _loginDbContext;

        public NonQueryDataService(LoginDbContext loginDbContext)
        {
            _loginDbContext = loginDbContext;
        }
        public async Task<T> Create(T entity)
        {
            var createdResult = await _loginDbContext.Set<T>().AddAsync(entity);
            await _loginDbContext.SaveChangesAsync();
            return createdResult.Entity;
        }

        public async Task<T> Update(int id, T entity)
        {
            entity.Id = id;
            _loginDbContext.Set<T>().Update(entity);
            await _loginDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            T entity = await _loginDbContext.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
            _loginDbContext.Set<T>().Remove(entity);
            await _loginDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<T> Get(int id)
        {
            var entity = await _loginDbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await _loginDbContext.Set<T>().ToListAsync();
            return entities;
        }
    }
}
