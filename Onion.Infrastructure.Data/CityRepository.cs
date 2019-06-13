using Onion.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Onion.Domain.Interfaces;

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
