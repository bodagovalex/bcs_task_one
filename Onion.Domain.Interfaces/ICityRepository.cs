using Onion.Domain.Core;
using System;
using System.Collections.Generic;

namespace Onion.Domain.Interfaces
{
    public interface ICityRepository : IDisposable
    {
        IEnumerable<City> GetCityList();
        City GetCity(int id);
    }
}
