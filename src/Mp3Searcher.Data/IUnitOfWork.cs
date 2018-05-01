using System;

namespace Mp3Searcher.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }
}