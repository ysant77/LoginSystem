using LoginSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Domain
{
    public interface IAccountService : IDataService<Account>
    {
        Task<Account> GetByUsername(string username);
        Task<Account> GetByEmail(string email);
    }
}
