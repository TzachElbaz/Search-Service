using System;
using System.Collections.Generic;
using System.IO;

namespace search_service
{
    public delegate void fileHandler(string newFile);
    class Search
    {
        //An event that occurs whenever a new file is found
        public event fileHandler newFileFound;
        public string keyWord { get; set; }
        public string searchPath { get; set; }
        public List<File> results { get; set; }

        public Search()
        {
            searchPath = "c:\\users";  //default search path
            results = new List<File>();
        }

        //Recursion that gets as input parameters a file name (or part of the name) - fileName
        //and a searching path (folder to start search from) - path
        //every time a file has found it will added to the file List (results)
        //and the 'newFileFound' event will emit
        public void fileSearch(string fileName, string path = "c:\\users")
        {
            // if the path does not exists the search will stop. 
            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException("The path you have searched doesn't exist");
            }

            //Checks if access to the folder has been denied 
            if (!isAccessible(path)) return;

            string[] filesArr = Directory.GetFiles(path, $"*{fileName}*");
            string[] foldersArr = Directory.GetDirectories(path);
            foreach (string i in filesArr)
            {
                results.Add(toFile(i));
                newFileFound(i);
            }

            //The search continues in each of the subfolders
            for (int i = 0; i < foldersArr.Length; i++)
            {
                fileSearch(fileName, foldersArr[i]);
            }
        }

        // Gets the full name and path of a file as one string(fullPath),
        // splits and returs the data as a 'File' object. 
        private File toFile(string fullPath)
        {
            string[] separatedPath = new string[2];
            separatedPath[0] = fullPath.Split("\\")[^1];
            separatedPath[1] = fullPath.Split(separatedPath[0])[0];
            File f1 = new File(separatedPath[0], separatedPath[1]);
            return f1;
        }

        private bool isAccessible(string path)
        {
            try
            {
                Directory.GetDirectories(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
