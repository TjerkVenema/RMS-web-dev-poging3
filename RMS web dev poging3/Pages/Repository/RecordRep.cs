using System;
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
                                       Database=rms;
                                       Uid=root;
                                       Pwd=Test12345;";

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
                "INSERT INTO record(user_id, artist, title, label, notes) VALUES (@user_id, @artist, @title, @label, @notes)",
                new
                {
                    user_id = newrecord.user_id,
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
                "SELECT * FROM record WHERE user_id = @user_id",
                new {user_id = ownerId}
            );
            return listrecords.ToList();
        }

        public static void UpdateForSale(record updateRecord)
        {
            using var connection = Connect();
            connection.Execute(
                "UPDATE record SET for_sale = 1, price = @price, notes = @notes WHERE record_id = @record_id",
                new
                {
                    price = updateRecord.price,
                    notes = updateRecord.notes,
                    record_id = updateRecord.record_id
                });
        }

        public static List<record> GetRecordsInCart(List<int> recordIds)
        {
            using var connection = Connect();
            var recordlist = new List<record>();
            foreach (var id in recordIds)
            {
                var record = connection.QuerySingleOrDefault<record>(
                    "SELECT * FROM record WHERE record_id = @record_id",
                    new
                    {
                        record_id = id
                    });
                recordlist.Add(record);
            }
            return recordlist;
        }

        public static void RecordSold(List<int> recordIds, int buyerId)
        {
            using var connection = Connect();
            foreach (var id in recordIds)
            {
                connection.Execute(
                    "UPDATE record SET for_sale = 0, user_id = @user_id WHERE record_id = @record_id",
                    new
                    {
                        user_id = buyerId,
                        record_id = id
                    });
            }
        }




    }


}