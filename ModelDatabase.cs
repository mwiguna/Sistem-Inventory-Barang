using System;
using System.Text;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Inventaris
{
    class ModelDatabase
    {
        public static MySqlConnection conn = null;
        public static Boolean createdDone = false;

        public ModelDatabase()
        {
            getConnection();
        }

        public static void getConnection()
        {
            if (conn == null)
            {
                string Connection = "datasource=localhost;port=3306;database=csharp_inventory;username=root;password=";
                conn = new MySqlConnection(Connection);
            }
        }

        public static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider md5 = new SHA1CryptoServiceProvider();
            UnicodeEncoding encoding     = new UnicodeEncoding();
            return Convert.ToBase64String(md5.ComputeHash(Encoding.ASCII.GetBytes(password)));
        }
    }
}
