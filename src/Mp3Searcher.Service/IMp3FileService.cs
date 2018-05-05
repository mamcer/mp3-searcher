using Mp3Searcher.Core;

namespace Mp3Searcher.Service
{
    public interface IMp3FileService
    {
        Mp3File GetMp3File(string path);

        bool Mp3FileExists(Mp3File mp3File);

        void SaveMp3File(Mp3File mp3File);
        
        void UpdateMp3File(Mp3File mp3File);
    }
}