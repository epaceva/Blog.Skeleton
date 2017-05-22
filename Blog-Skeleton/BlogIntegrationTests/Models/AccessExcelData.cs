using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogIntegrationTests.Models
{
    public class AccessExcelData
    {
        public static string TestDataFileConnectionRegistration()
        {
            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var filename = "RegistrationUserData.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                              Data Source = {0}; 
		                              Extended Properties=Excel 12.0;", path + filename);
            return con;
        }

        public static RegistrationUser GetTestDataRegistration(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnectionRegistration()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<RegistrationUser>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

        public static string TestDataFileConnectionLogin()
        {
            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var filename = "LoginUserData.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                              Data Source = {0}; 
		                              Extended Properties=Excel 12.0;", path + filename);
            return con;
        }

        public static LoginUser GetTestDataLoging(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnectionLogin()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<LoginUser>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}