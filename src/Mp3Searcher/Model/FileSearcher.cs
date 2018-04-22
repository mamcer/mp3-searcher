using System.IO;

namespace Mp3Searcher.Model
{
    class FileSearcher
    {
        private Mp3FileCollection mp3FileCollection;
        private static FileSearcher instance = null;

        #region constructor
       
        private FileSearcher()
        {
            mp3FileCollection = new Mp3FileCollection();
        }
        
        #endregion

        #region properties
      
        public static FileSearcher Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileSearcher();
                }
                return instance;
            }
        }

        public Mp3FileCollection SearchResult
        {
            get
            {
                return mp3FileCollection;
            }
        }
       
        #endregion

        #region public methods
      
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
                                mp3FileCollection.Add(mp3File);
                            }
                        }
                        DirectorySearch(host, d);
                    }
                    catch{}
                }
            }
            catch
            {
            }
        }

        public int SearchForMp3Files(NetworkHost nh)
        {
            mp3FileCollection = new Mp3FileCollection();
            DirectorySearch(nh.HostName, nh.Path);
            return mp3FileCollection.Mp3Files.Count;
        }

        #endregion
    }
}