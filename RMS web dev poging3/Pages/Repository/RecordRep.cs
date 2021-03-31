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
        public static IDbConnection Connect()
        {
            string connectionString = @"
                                       Server=127.0.0.1; Port=3306;
                                       Database=srmusic;
                                       Uid=root;
                                       Pwd=Test@1234!;";

            return new MySqlConnection(connectionString);
        }
        
        public static List<record> Get()
        {
            using var connection = Connect();
            var gift = connection.Query<record>("SELECT * FROM record");
            return gift.ToList();
        }

        public static void AddRecord(record newrecord)
        {
            using var connection = Connect();
            connection.Execute(
                "INSERT INTO record(owner, artist, title, label, notes) VALUES (@owner, @artist, @title, @label, @notes)",
                new
                {
                    owner = newrecord.owner,
                    artist = newrecord.artist,
                    title = newrecord.title,
                    label = newrecord.label,
                    notes = newrecord.notes
                });
        }
        
        public static List<record> GetRecordsByOwner(int ownerId)
        {
            using var connection = Connect(); 
            var listrecords = connection.Query<record>(
                "SELECT * FROM record WHERE owner = @owner",
                new {owner = ownerId}
            );
            return listrecords.ToList();
        }




    }


}