using System;
using System.Data.SqlClient;

namespace BLL_to_dbFiles
{
    public class dbTable
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-JPC1MLUP\SQLEXPRESS;Initial Catalog=dbFiles;Integrated Security=True");
        SqlCommand insertCom=new SqlCommand();
        SqlCommand selectCom = new SqlCommand();

        public dbTable()
        {
            insertCom.Connection = cn;
            selectCom.Connection = cn;
        }

       
        //Get the searching data and insert it to the 'Searches' table
        //Returns the SearchID that created. 
        public int insertIntoSearches(string key, int results, string path = "C:\\users")
        {
            int newSearchID;
            insertCom.CommandText = "insert Seareches(KeyWord,SearchingPath,NumberOfResults)" +
                              " values('" + key + "', '" + path + "', " + results + ")";
            selectCom.CommandText = "select SearchID from Seareches where KeyWord='" + key +
                        "' and SearchingPath='" + path + "'";
            cn.Open();
            insertCom.ExecuteNonQuery();
            newSearchID = int.Parse(selectCom.ExecuteScalar().ToString());
            cn.Close();
            return newSearchID;
        }

        //Gets the results that has found and insert the data into the "Results" table
        public void insertIntoResults(int sID, string fName, string fType, string fLocation)
        {
            insertCom.CommandText = $"insert Results values({sID},'{fName}','{fType}','{fLocation}')";
            cn.Open();
            insertCom.ExecuteNonQuery();
            cn.Close();
        }
    }
}
