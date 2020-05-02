using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavicatOfWPF.Db
{
    class DbManage
    {
        
        public enum DbType
        {
            MySQL,
            PostgreSQL,
            Oracle,
            SQLite,
            SQL_Server,
            MariaDB
        }

        public static dynamic GetDbConnection(DbType dbType, dynamic dbConnection)
        {

            return dbConnection;
        }
    }
}
