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
        

    }
}
