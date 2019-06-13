using Onion.Domain.Core;
using Onion.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Onion.Infrastructure.Data
{
    public class CityRepository: ICityRepository
    {
        private EntityContext db;

        public CityRepository()
        {
            this.db = new EntityContext();
        }

        public IEnumerable<City> GetCityList()
        {
            return db.Cities.Where(c => c.IsDeleted.Equals(false)).ToList();
        }

        public City GetCity(int id)
        {
            return db.Cities.Find(id);
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
