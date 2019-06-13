using Onion.Domain.Core;
using System;

namespace Onion.Services.Interfaces
{
    public interface IUser : IDisposable
    {
        void RegistreUser(User user);
    }
}
