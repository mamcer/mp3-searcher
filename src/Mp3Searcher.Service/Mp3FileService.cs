using System;
using System.IO;
using Mp3Searcher.Core;

namespace Mp3Searcher.Service
{
    public class Mp3FileService
    {
        public Mp3File GetMp3File(string path)
        {
            TagLib.File file = TagLib.File.Create(path);

            string title = file.Tag.Title;
            string album = file.Tag.Album;
            string[] artists = file.Tag.AlbumArtists;
            int year = (int)file.Tag.Year;
            string[] genres = file.Tag.Genres;
            string artist = string.Empty;

            foreach (string a in artists)
            {
                if (artist != string.Empty)
                {
                    artist += $"-{a}";
                }
                else
                {
                    artist = a;
                }
            }

            if (title == string.Empty && album == string.Empty && artist == string.Empty)
            {
                return null;
            }

            if (title == string.Empty)
            {
                title = Path.GetFileNameWithoutExtension(path);
            }

            string genre = string.Empty;
            foreach (string g in genres)
            {
                if (genre != string.Empty)
                {
                    genre += $"-{g}";
                }
                else
                {
                    genre = g;
                }
            }

            var duration = new TimeSpan(file.Properties.Duration.Hours, file.Properties.Duration.Minutes, file.Properties.Duration.Seconds);

            return new Mp3File
            {
                Title = title,
                Album = album,
                Artist = artist,
                Year = year,
                Genre = genre,
                Duration = duration,
                Bitrate = file.Properties.AudioBitrate
            };
        }

        public void SaveMp3File(Mp3File mp3File)
        {
            // TODO: implement!
        }
    }
}
