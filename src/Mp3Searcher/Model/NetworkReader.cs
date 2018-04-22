using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

using Mp3Searcher.Data;

namespace Mp3Searcher.Model
{
    class NetworkHost
    {
        private string hostName;
        private string path;

        #region constructor
        public NetworkHost()
        {
            HostName = string.Empty;
            Path = string.Empty;
        }
        #endregion

        #region properties
        public string HostName
        {
            get
            {
                return hostName;
            }
            set
            {
                hostName = value;
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

        #region public methods
        public void MapData(DataRow dr)
        {
            if (dr != null)
            {
                hostName = dr[NetworkHostServiceData.HOST].ToString();
                path = dr[NetworkHostServiceData.PATH].ToString();
            }
        }
        #endregion
    }

    class NetworkReader : IEnumerable, IEnumerator
    {
        private int lastHostNumber;
        private int specialFolderIndex;
        private string[] specialFolders = { "Documents and Settings", "Music", "Musica" }; 

        #region constructor

        public NetworkReader()
        {
            lastHostNumber = 0;
            specialFolderIndex = -1;
        }

        #endregion

        #region public methods
        public bool ResetSpecialFolder()
        { 
            if(specialFolderIndex < specialFolders.Length - 1)
            {
                specialFolderIndex += 1;
                return false;
            }
            else
            {
                specialFolderIndex = 0;
                return true;
            }
        }

        public string GetHostNumber()
        {
            if (lastHostNumber < 10)
            {
                return "00" + lastHostNumber.ToString();
            }
            else
            {
                if (lastHostNumber < 100)
                {
                    return "0" + lastHostNumber.ToString();
                }
            }
            return lastHostNumber.ToString();
        }

        public void ResumeFromHost(string hostName)
        {
            hostName = hostName.Remove(0,4);
            lastHostNumber = Convert.ToInt32(hostName);
            specialFolderIndex = -1;
        }
        #endregion 

        #region Inumerable, IEnumerator
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public object Current
        {
            get
            {
                NetworkHost networkHost = new NetworkHost();
                string hostNumber = GetHostNumber();
                networkHost.HostName = "HXWS" + hostNumber;
                networkHost.Path = "\\\\HXWS" + hostNumber + "\\c$\\" + specialFolders[specialFolderIndex];
                return networkHost;
            }
        }
        public void Dispose() { }

        public bool MoveNext()
        {
            if (ResetSpecialFolder() == true)
            {
                lastHostNumber += 1;
                return lastHostNumber < 150;
            }
            return true;
        }
        public void Reset()
        {
            lastHostNumber = 0;
        }
        #endregion
    }
}
