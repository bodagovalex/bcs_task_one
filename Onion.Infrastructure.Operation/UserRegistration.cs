using Onion.Domain.Core;
using Onion.Infrastructure.Data;
using Onion.Services.Interfaces;
using System;

namespace Onion.Infrastructure.Operation
{
    public class UserRegistration : IUser
    {
        private EntityContext db;

        public UserRegistration()
        {
            this.db = new EntityContext();
        }

        public void RegistreUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
