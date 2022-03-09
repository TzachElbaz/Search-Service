using System;
using System.Collections.Generic;
using System.Text;
using BLL_to_dbFiles;


namespace search_service
{
    class Data
    {
        public Search record { get; set; }
        public dbTable dbt { get; set; }
        public Data(Search value)
        {
            record = value;
            dbt = new dbTable();
        }

        public void Post()
        {
            int searchID;
            //Sends information to the DLL for filling a new row in the 'Searches" table
            //Gets back the number value of the SearchID that created.   
            searchID=dbt.insertIntoSearches(record.keyWord, record.results.Count, record.searchPath);

            //Sends information to the DLL for filling a new row in the 'Results" table
            foreach (File i in record.results)
            {
                dbt.insertIntoResults(searchID, i.fileName, i.fileType, i.location);
            }
        }

    }
}
