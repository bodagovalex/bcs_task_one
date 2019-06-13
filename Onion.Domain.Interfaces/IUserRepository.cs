using Onion.Domain.Core;
using System;
using System.Collections.Generic;

namespace Onion.Domain.Interfaces
{
    public interface IUserRepository: IDisposable
    {
        IEnumerable<User> GetUserList();
        User GetUser(int id);
        void Create(User item);
        void Update(User item);
        void Delete(int id);
        void Save();
    }
}
