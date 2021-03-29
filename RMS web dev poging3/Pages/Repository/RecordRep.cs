using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using RMS_web_dev_poging3.Pages.Models;


namespace RMS_web_dev_poging3.Pages.Repository
{
    public class RecordRep
    {
        public IDbConnection Connect()
        {
            string connectionString = @"
                                       Server=127.0.0.1; Port=3306;
                                       Database=srmusic;
                                       Uid=Smull;
                                       Pwd=Test@1234!;";

            return new MySqlConnection(connectionString);
        }
        
        public List<record> Get()
        {

            using var connection = Connect();
            List<record> gift = connection.Query<record>("SELECT * FROM record").ToList();
            return gift;

        }
        




    }


}