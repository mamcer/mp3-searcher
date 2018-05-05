using System.Collections.Generic;

namespace Mp3Searcher.Service
{
    public interface INetworkService
    {
        byte[] GetMyIp();

        List<string> GetNetworkShareFoldersList(string serverName, bool excludeSystemShares = true);
    }
}