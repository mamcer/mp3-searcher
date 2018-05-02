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

        public int Id { get; set; }

        public string Title { get; set; }

        public string Album { get; set; }

        public string Artist { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public TimeSpan Duration { get; set; }

        public int Bitrate { get; set; }
    
        public List<Mp3FileLocation> FileLocations { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Mp3File mp3File)
            {
                return mp3File.Title == Title && mp3File.Album == Album && mp3File.Artist == Artist;
            }

            return false;
        }
    }
}
