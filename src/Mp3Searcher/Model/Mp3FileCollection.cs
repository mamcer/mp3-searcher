using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Mp3Searcher.Data;

namespace Mp3Searcher.Model
{
    class Mp3FileCollection
    {
        private ArrayList mp3Files;

        #region properties
        public ArrayList Mp3Files
        {
            get
            {
                return mp3Files;
            }
        }
        #endregion

        #region constructor
        public Mp3FileCollection()
        {
            mp3Files = new ArrayList();
        }
        #endregion

        #region public methods
        public void Add(Mp3File mp3File)
        {
            Mp3Files.Add(mp3File);
        }

        public void Save()
        {
            foreach (Mp3File mp3File in Mp3Files)
            {
                Mp3FileServiceData.Instance.SaveMp3(mp3File.Title, mp3File.Album, mp3File.Artist, mp3File.Host, mp3File.Path);
            }
        }
        #endregion
    }
}
