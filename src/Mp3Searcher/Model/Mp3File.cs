using System.Data;

namespace Mp3Searcher.Model
{
    public class Mp3File
    {
        private string title;
        private string album;
        private string artist;
        private string host;
        private string path;

        #region constructors
        public Mp3File() 
        {
            Title = "";
            Album = "";
            Artist = "";
            Host = "";
            Path = "";
        }

        public Mp3File(string t, string al, string ar, string h, string p)
        {
            Title = t;
            Album = al;
            Artist = ar;
            Host = h;
            Path = p;
        }
        #endregion

        #region service data
        public void MapData(DataRow dr)
        {
            if (dr != null)
            {
                //Title = dr[Mp3FileServiceData.TITLE].ToString();
                //Album = dr[Mp3FileServiceData.ALBUM].ToString();
                //Artist = dr[Mp3FileServiceData.ARTIST].ToString();
                //Host = dr[Mp3FileServiceData.HOST].ToString();
                //Path = dr[Mp3FileServiceData.PATH].ToString();
            }
        }
        #endregion

        #region properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Album
        {
            get
            {
                return album;
            }
            set
            {
                album = value;
            }
        }
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }
        public string Host
        {
            get
            {
                return host;
            }
            set
            {
                host = value;
            }
        }
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }
        #endregion
    }
}
