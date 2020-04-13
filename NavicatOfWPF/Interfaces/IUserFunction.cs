using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavicatOfWPF.Interfaces
{
    interface IUserFunction
    {
        bool SignIn(string name, string pwd);       // 注册
        bool LogIn(string name, string pwd);        // 登录

        bool ConnectToDB(string dbName);            // 链接数据库
        
        // 新建表  删除表
        void NewTable(string table);
        void DelTable(string table);

        // 查找操作
        void QueryAll(string table);
        void QueryData(string table, string condition);

        // 删除操作
        void DelData(string table, string condition);

        // 添加操作
        void AddData(string table, string data);

        // 插入操作
        void InsertData(string table, string data, string conditon);
    }
}
