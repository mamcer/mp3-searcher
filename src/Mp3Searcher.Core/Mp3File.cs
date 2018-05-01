using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mp3Searcher.Core
{
    [Table("Mp3File")]
    public class Mp3File
    {
        public Mp3File()
        {
            FileLocations = new List<Mp3FileLocation>();
        }

        public string Title { get; set; }

        public string Album { get; set; }

        public string Artist { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public TimeSpan Duration { get; set; }

        public int Bitrate { get; set; }
    
        public List<Mp3FileLocation> FileLocations { get; set; }
    }
}
