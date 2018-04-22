using System;
using System.Collections.Generic;
using System.Text;

namespace Mp3Searcher.Model
{
    class Id3Reader
    {
        private static Id3Reader instance = null;

        #region constructor
        public Id3Reader() { }
        #endregion

        #region properties
        public static Id3Reader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Id3Reader();
                }
                return instance;
            }
        }
        #endregion

        #region public methods
        public Mp3File GetMp3File(string fullPath)
        {
            Mp3File mp3File = new Mp3File();
            try
            {
                //parse file name
                string fileName = fullPath.Substring(fullPath.LastIndexOf("\\") + 1);
                //parse file path
                string filePath = fullPath.Substring(0, fullPath.LastIndexOf("\\"));
                //create shell instance
                Shell32.Shell shell = new Shell32.ShellClass();
                //set the namespace to file path
                Shell32.Folder folder = shell.NameSpace(filePath);
                //get ahandle to the file
                Shell32.FolderItem folderItem = folder.ParseName(fileName);
                //did we get a handle ?
                if (folderItem != null)
                {
                    mp3File.Title = folder.GetDetailsOf(folderItem, 10);
                    if (string.IsNullOrEmpty(mp3File.Title))
                    {
                        mp3File.Title = fileName;
                    }
                    mp3File.Album = folder.GetDetailsOf(folderItem, 17);
                    mp3File.Artist = folder.GetDetailsOf(folderItem, 9);
                }
                else
                {
                    mp3File = null;
                }
                //clean ip
                folderItem = null;
                folder = null;
                shell = null;
            }
            catch 
            {
                mp3File = null;
            }
            return mp3File;
        }
        #endregion
    }
}
