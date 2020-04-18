using NavicatOfWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavicatOfWPF.Db
{
    class DbMySQL : IUserFunction
    {
        public void AddData(string table, string data)
        {
            throw new NotImplementedException();
        }

        public bool ConnectToDB(string dbName)
        {
            throw new NotImplementedException();
        }

        public void DelData(string table, string condition)
        {
            throw new NotImplementedException();
        }

        public void DelTable(string table)
        {
            throw new NotImplementedException();
        }

        public void InsertData(string table, string data, string conditon)
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string name, string pwd)
        {
            throw new NotImplementedException();
        }

        public void NewTable(string table)
        {
            throw new NotImplementedException();
        }

        public void QueryAll(string table)
        {
            throw new NotImplementedException();
        }

        public void QueryData(string table, string condition)
        {
            throw new NotImplementedException();
        }

        public bool SignIn(string name, string pwd)
        {
            throw new NotImplementedException();
        }
    }
}
