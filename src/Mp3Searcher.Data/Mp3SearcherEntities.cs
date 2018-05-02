using System.Data.Entity;
using Mp3Searcher.Core;

namespace Mp3Searcher.Data
{
    public class Mp3SearcherEntities : DbContext
    {
        public Mp3SearcherEntities() : base("name=Mp3SearcherEntities")
        {
        }

        public virtual DbSet<Mp3File> Mp3Files { get; set; }

        public virtual DbSet<Mp3FileLocation> Mp3FileLocations { get; set; }
    }
}