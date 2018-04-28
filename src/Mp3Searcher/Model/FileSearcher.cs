using System.Collections.Generic;
using System.IO;
using Mp3Searcher.Core;

namespace Mp3Searcher.Model
{
    class FileSearcher
    {
        private List<Mp3File> _mp3FileCollection;
        private static FileSearcher _instance;

        private FileSearcher()
        {
            _mp3FileCollection = new List<Mp3File>();
        }

        public static FileSearcher Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FileSearcher();
                }
                
                return _instance;
            }
        }

        public List<Mp3File> SearchResult => _mp3FileCollection;

        private void DirectorySearch(string host, string path)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    try
                    {
                        foreach (string f in Directory.GetFiles(d, "*.mp3"))
                        {
                            Mp3File mp3File = Id3Reader.Instance.GetMp3File(f);
                            if (mp3File != null)
                            {
                                mp3File.Path = f;
                                mp3File.Host = host;
                                _mp3FileCollection.Add(mp3File);
                            }
                        }
                        DirectorySearch(host, d);
                    }
                    catch
                    {
                        // ignored
                    }
                }
            }
            catch
            {
                // ignored
            }
        }

        public int SearchForMp3Files(NetworkHost nh)
        {
            _mp3FileCollection = new List<Mp3File>();
            DirectorySearch(nh.HostName, nh.Path);
            return _mp3FileCollection.Count;
        }
    }
}