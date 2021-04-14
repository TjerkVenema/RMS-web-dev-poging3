using System.Data;
using Dapper;
using MySql.Data.MySqlClient;
using RMS_web_dev_poging3.Pages.Models;

namespace RMS_web_dev_poging3.Pages.Repository
{
    public class UserRep
    {
        public static IDbConnection Connect()
        {
            string connectionString = @"
                                       Server=127.0.0.1; Port=3306;
                                       Database=srm;
                                       Uid=root;
                                       Pwd=Test1234;";

            return new MySqlConnection(connectionString);
        }

        public static void Adduser(user newUser)
        {
            using var connection = Connect(); 
            connection.Execute(
                "INSERT INTO user(password, emailadres) VALUES (@password, @emailadres)",
                new
                {
                    password = newUser.password,
                    emailadres = newUser.emailadres,
                });
        }

        public static user Login(string emailadres, string password)
        {
            using var connection = Connect();
            var user = connection.QuerySingleOrDefault<user>(
                "SELECT * FROM user WHERE password = @password AND emailadres = @emailadres",
                new
                {
                    password = password,
                    emailadres = emailadres,
                });
            return user;
        }
    }
}