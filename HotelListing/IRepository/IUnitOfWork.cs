using HotelListing.Data;
using System;

namespace HotelListing.IRepository
{
    public class IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
