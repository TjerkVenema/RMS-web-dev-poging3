using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using RMS_web_dev_poging3.Pages.Models;

namespace RMS_web_dev_poging3.Pages.Repository
{
    public class Record_For_SaleRep
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

        public static void RecordSold(List<record> recordsSold, float buyerId)
        {
            using var connection = Connect();
            foreach (var record in recordsSold)
            {
                connection.Execute(
                    "INSERT INTO record_for_sale(record_id, user_id, price_sold) VALUES(@record_id, @user_id, @price_sold)",
                    new
                    {
                        record_id = record.record_id,
                        user_id = buyerId,
                        price_sold = record.price
                    });
            }

            
        }
    }
}