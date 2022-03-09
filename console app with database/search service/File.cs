using System;
using System.Collections.Generic;
using System.Text;

namespace search_service
{
    class File
    {
        public string fileName { get; set; }
        public string location { get; set; }
        public string fileType { get; set; }

        public File(string fName, string fLocation)
        {
            fileName = fName;
            location = fLocation;
            fileType = findFileType();
        }

        
        //Gets the full path and name of a file as one string parameter (fullName)
        //Splits and returns the extention of the file(the last part of the full string)
        private string findFileType()
        {
            string[] fullName = fileName.Split(".");
            return fullName[fullName.GetUpperBound(0)];
        }

        public override string ToString()
        {
            return location+fileName;
        }
    }
}
