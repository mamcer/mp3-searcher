using System.Data;

namespace Mp3Searcher.Data
{
    class NetworkHostServiceData : DataServiceBase
    {
        public const string HOST = "host";
        public const string PATH = "path";

        private static NetworkHostServiceData instance = null;

        #region constructor

        private NetworkHostServiceData()
            : base()
        {
        }

        #endregion

        #region properties

        public static NetworkHostServiceData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NetworkHostServiceData();
                }

                return instance;
            }
        }

        #endregion

        #region public methods
        
        public DataRow GetNetworkHost()
        {
            DataSet ds = ExecuteDataSet("GetNetworkHost");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0];
            }
            else
            {
                return null;
            }
        }

        public void Reset()
        {
            ExecuteNonQuery("ResetNetworkHost");
        }

        public void SetNetworkHost(string host, string path)
        {
            ExecuteNonQuery("SetNetworkHost", CreateParameter("@host", SqlDbType.VarChar, host), CreateParameter("@path", SqlDbType.VarChar, path));
        }
        #endregion
    }
}