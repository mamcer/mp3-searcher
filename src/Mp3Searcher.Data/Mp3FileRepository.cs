using System.Data.Entity;
using System.Linq;
using Mp3Searcher.Core;

namespace Mp3Searcher.Data
{
    public class Mp3FileRepository : EntityFrameworkRepository<Mp3File, int>, IMp3FileRepository
    {
        public Mp3FileRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public bool Exists(Mp3File mp3File)
        {
            return _dbContext.Set<Mp3File>().Any(m => m.Title == mp3File.Title);

            //return _dbContext.Set<Mp3File>().Any(m => m.Equals(mp3File));
        }
    }
}