using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavicatOfWPF.Db
{
    class DbConfig
    {
        private string server;
        private string username;
        private string pwd;

        private static string connectionString;
        public DbConfig(string server, string username, string pwd)
        {
            this.server = server;
            this.username = username;
            this.pwd = pwd;
            connectionString = "server=" + server + ";uid=" + username + ";pwd=" + pwd;
        }

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
    }
}
