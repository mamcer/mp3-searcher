using System.Data;

namespace Mp3Searcher.Data
{
    class Mp3FileServiceData : DataServiceBase
    {
        public const string TITLE = "title";
        public const string ALBUM = "album";
        public const string ARTIST = "artist";
        public const string HOST = "host";
        public const string PATH = "path";

        private static Mp3FileServiceData instance = null;

        #region constructor
        private Mp3FileServiceData() : base()
        { 
        }
        #endregion

        #region properties
        public static Mp3FileServiceData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Mp3FileServiceData();
                }

                return instance;
            }
        }
        #endregion

        #region public methods
        public DataRow GetMp3FileById(int id)
        {
            DataSet ds = ExecuteDataSet("GetMp3FileById", CreateParameter("@id", SqlDbType.Int, id));
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0].Rows[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable SearchByTitle(string title)
        {
            DataSet ds = ExecuteDataSet("GetMp3FileLinkByTitle", CreateParameter("@title", SqlDbType.VarChar, title));
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }

        public DataTable SearchByAlbum(string album)
        {
            DataSet ds = ExecuteDataSet("GetMp3FileLinkByAlbum", CreateParameter("@album", SqlDbType.VarChar, album));
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }

        public DataTable SearchByArtist(string artist)
        {
            DataSet ds = ExecuteDataSet("GetMp3FileLinkByArtist", CreateParameter("@artist", SqlDbType.VarChar, artist));
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }

        public void SaveMp3(string title, string album, string artist, string host, string path)
        {
            ExecuteNonQuery("SaveMp3FileLink",
                CreateParameter("@title", SqlDbType.VarChar, title),
                CreateParameter("@album", SqlDbType.VarChar, album),
                CreateParameter("@artist", SqlDbType.VarChar, artist),
                CreateParameter("@host", SqlDbType.VarChar, host),
                CreateParameter("@path", SqlDbType.VarChar, path));
        }
        #endregion
    }
}
