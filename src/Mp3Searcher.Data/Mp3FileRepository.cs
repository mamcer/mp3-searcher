using System.Data.Entity;
using Mp3Searcher.Core;

namespace Mp3Searcher.Data
{
    public class Mp3FileRepository : EntityFrameworkRepository<Mp3File, int>, IMp3FileRepository
    {
        public Mp3FileRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}