namespace Mp3Searcher.Core
{
    public class NetworkHost
    {
        public NetworkHost()
        {
            HostName = string.Empty;
            Path = string.Empty;
        }

        public string HostName { get; set; }

        public string Path { get; set; }
    }
}