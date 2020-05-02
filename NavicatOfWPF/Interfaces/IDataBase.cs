using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavicatOfWPF.Interfaces
{
    interface IDataBase
    {
        // 新建表  删除表
        void NewTable(string table, List<DbColumnInfo> columnInfos);
        void DelTable(string table);

        // 查找操作
        DataTable QueryAll(string table);
        DataTable QueryData(string table, string condition);

        // 删除操作
        void DelData(string table, string condition);


        // 插入操作
        void InsertData(string table, dynamic data);
    }
}
