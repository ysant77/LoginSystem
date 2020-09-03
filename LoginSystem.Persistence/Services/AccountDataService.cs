using LoginSystem.Domain;
using LoginSystem.Domain.Models;
using LoginSystem.Persistence.Services.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Persistence.Services
{
    public class AccountDataService : IAccountService
    {
        private readonly LoginDbContext _loginDbContext;
        private readonly NonQueryDataService<Account> _nonQueryDataService;

        public AccountDataService(LoginDbContext loginDbContext)
        {
            _loginDbContext = loginDbContext;
            _nonQueryDataService = new NonQueryDataService<Account>(loginDbContext);
        }

        public async Task<Account> Create(Account entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<Account> Get(int id)
        {
            return await _nonQueryDataService.Get(id);
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            return await _nonQueryDataService.GetAll();
        }

        public async Task<Account> GetByEmail(string email)
        {
            var account = await _loginDbContext.Accounts
                                                .Include(a => a.AccountHolder)
                                                .FirstOrDefaultAsync(a => a.AccountHolder.Email == email);
            return account;
        }

        public async Task<Account> GetByUsername(string username)
        {
            var account = await _loginDbContext.Accounts
                                                .Include(a => a.AccountHolder)
                                                .FirstOrDefaultAsync(a => a.AccountHolder.Username == username);
            return account;
        }

        public async Task<Account> Update(int id, Account entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}