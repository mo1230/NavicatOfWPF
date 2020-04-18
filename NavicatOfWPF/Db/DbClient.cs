using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavicatOfWPF.Db
{
    class DbClient
    {
        private static dynamic type;
        public static SqlSugarClient GetSqlSugarClient(string dbType)
        {
            
            switch (dbType)
            {
                case "MySql":
                    type = DbType.MySql;
                    break;
                case "SqlServer":
                    type = DbType.SqlServer;
                    break;
                case "Oracle":
                    type = DbType.Oracle;
                    break;
                case "Sqlite":
                    type = DbType.Sqlite;
                    break;
                case "PostgreSQL":
                    type = DbType.PostgreSQL;
                    break;
                default:
                    break;
            }
            SqlSugarClient db = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = DbConfig.ConnectionString,
                    DbType = type,
                    IsAutoCloseConnection = true,
                    InitKeyType = InitKeyType.Attribute
                }
                );
            
            return db;
        }
    }
}
