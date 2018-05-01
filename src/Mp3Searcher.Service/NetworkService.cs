using System.Collections.Generic;
using System.Management;
using System.Net;
using System.Net.Sockets;

namespace Mp3Searcher.Service
{
    public class NetworkService
    {
        public byte[] GetMyIp()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                
                return endPoint?.Address.GetAddressBytes();
            }
        }

        public List<string> GetNetworkShareFoldersList(string serverName, bool excludeSystemShares=true)
        {
            List<string> shares = new List<string>();
            ConnectionOptions connectionOptions = new ConnectionOptions();
 
            ManagementScope scope = new ManagementScope("\\\\" + serverName + "\\root\\CIMV2", connectionOptions);
            scope.Connect();
 
            ManagementObjectSearcher worker = new ManagementObjectSearcher(scope, new ObjectQuery("select Name from win32_share"));

            foreach (var managementObject in worker.Get())
            {
                var share = (ManagementObject) managementObject;
                var shareName = share["Name"].ToString();
                if (excludeSystemShares && shareName.EndsWith("$"))
                {
                    continue;
                }

                shares.Add(shareName);
            }

            return shares;
        }
    }
}