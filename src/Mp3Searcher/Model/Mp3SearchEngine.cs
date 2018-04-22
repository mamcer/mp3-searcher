using System.Data;

namespace Mp3Searcher.Model
{
    class Mp3SearchEngine
    {
        private static Mp3SearchEngine instance = null;
        private NetworkReader networkReader;

        #region constructor
        
        public Mp3SearchEngine()
        {
            networkReader = new NetworkReader();
        }
        
        #endregion

        #region properties
        
        public static Mp3SearchEngine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Mp3SearchEngine();
                }

                return instance;
            }
        }

        #endregion 

        #region public methods

        public int FullScan()
        {
            int filesAdded = 0;
            foreach (NetworkHost nh in networkReader)
            {
                //Save search state, for resume
//                NetworkHostServiceData.Instance.SetNetworkHost(nh.HostName, nh.Path);
                filesAdded += FileSearcher.Instance.SearchForMp3Files(nh);
                Mp3FileCollection mp3FileCollection = FileSearcher.Instance.SearchResult;
                mp3FileCollection.Save();
            }

//            NetworkHostServiceData.Instance.Reset();
            return filesAdded;
        }

        public int ResumeFullScan(string hostName)
        {
            networkReader.ResumeFromHost(hostName);
            return FullScan();
        }

        public DataTable SearchTitle(string title)
        {
//            return Mp3FileServiceData.Instance.SearchByTitle(title);
            return null;
        }

        public DataTable SearchAlbum(string album)
        {
//            return Mp3FileServiceData.Instance.SearchByAlbum(album);
            return null;
        }

        public DataTable SearchArtist(string artist)
        {
//            return Mp3FileServiceData.Instance.SearchByArtist(artist);
            return null;
        }

        public string GetFilePath(int idMp3FileLink)
        {
//            DataRow dr = Mp3FileServiceData.Instance.GetMp3FileById(idMp3FileLink);
//          if (dr != null)
            {
//                return dr[Mp3FileServiceData.PATH].ToString();
            }
            return string.Empty;
        }

        public Mp3File GetMp3File(int idMp3FileLink)
        {
            Mp3File mp3File = null;
//            DataRow dr = Mp3FileServiceData.Instance.GetMp3FileById(idMp3FileLink);
//            if (dr != null)
            {
                mp3File = new Mp3File();
//                mp3File.MapData(dr);
            }

            return mp3File;
        }

        #endregion
    }
}
