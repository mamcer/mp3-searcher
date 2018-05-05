using Mp3Searcher.Core;

namespace Mp3Searcher.Data
{
    public interface IMp3FileRepository : IRepository<Mp3File, int>
    {
        bool Exists(Mp3File mp3File);
    }
}