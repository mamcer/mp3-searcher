using System;
using System.Collections;
using System.Data;

namespace Mp3Searcher.Model
{
    class NetworkHost
    {
        public NetworkHost()
        {
            HostName = string.Empty;
            Path = string.Empty;
        }

        public string HostName { get; set; }

        public string Path { get; set; }
        
        public void MapData(DataRow dr)
        {
            if (dr != null)
            {
                //hostName = dr[NetworkHostServiceData.HOST].ToString();
                //path = dr[NetworkHostServiceData.PATH].ToString();
            }
        }
    }

    class NetworkReader : IEnumerable, IEnumerator
    {
        private int _lastHostNumber;
        private int _specialFolderIndex;
        private readonly string[] _specialFolders = { "Documents and Settings", "Music", "Musica" }; 

        public NetworkReader()
        {
            _lastHostNumber = 0;
            _specialFolderIndex = -1;
        }

        public bool ResetSpecialFolder()
        { 
            if(_specialFolderIndex < _specialFolders.Length - 1)
            {
                _specialFolderIndex += 1;
                return false;
            }
            else
            {
                _specialFolderIndex = 0;
                return true;
            }
        }

        public string GetHostNumber()
        {
            if (_lastHostNumber < 10)
            {
                return "00" + _lastHostNumber.ToString();
            }
            else
            {
                if (_lastHostNumber < 100)
                {
                    return "0" + _lastHostNumber.ToString();
                }
            }
            return _lastHostNumber.ToString();
        }

        public void ResumeFromHost(string hostName)
        {
            hostName = hostName.Remove(0,4);
            _lastHostNumber = Convert.ToInt32(hostName);
            _specialFolderIndex = -1;
        }
        
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        
        public object Current
        {
            get
            {
                NetworkHost networkHost = new NetworkHost();
                string hostNumber = GetHostNumber();
                networkHost.HostName = "HXWS" + hostNumber;
                networkHost.Path = "\\\\HXWS" + hostNumber + "\\c$\\" + _specialFolders[_specialFolderIndex];
                return networkHost;
            }
        }
        
        public void Dispose() { }

        public bool MoveNext()
        {
            if (ResetSpecialFolder())
            {
                _lastHostNumber += 1;
                return _lastHostNumber < 150;
            }
            return true;
        }
     
        public void Reset()
        {
            _lastHostNumber = 0;
        }
    }
}
