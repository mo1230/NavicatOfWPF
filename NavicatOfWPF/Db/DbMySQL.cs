using NavicatOfWPF.Interfaces;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NavicatOfWPF.Db
{
    class DbMySQL : IDataBase
    {
        private readonly SqlSugarClient db;
        private static DbMySQL dbMySQL;

        private DbMySQL(string ip, string username, string pwd)
        {
            // 先配置数据库
            DbConfig dbConfig = new DbConfig(ip, username, pwd);
            // 建立sqlsugar客户端
            try
            {
                if (this.db == null)
                {
                    this.db = DbClient.GetSqlSugarClient("MySql");
                    if (this.db != null)
                    {
                        MessageBox.Show("连接成功");
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// 获取DbMySQL实例
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static DbMySQL GetDbInstance(string ip, string username, string pwd)
        {
            if (dbMySQL == null)
            {
                dbMySQL = new DbMySQL(ip, username, pwd);
            }
            else
            {
                MessageBox.Show("连接已存在");
            }
            return dbMySQL;
            
        }

        public List<string> GetDbInfo()
        {
            try
            {
               return this.db.DbMaintenance.GetDataBaseList(this.db);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return null;
            }
        }
        /// <summary>
        /// 根据条件删除数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="condition"></param>
        public void DelData(string table, string condition)
        {
            string sql = "DELETE FROM @table WHERE @condition";
            SugarParameter[] parameter =
            {
                new SugarParameter("@table", table),
                new SugarParameter("@condition", condition),
            };
            int num = this.db.Ado.ExecuteCommand(sql, parameter);
            if (num != 0)
            {
                MessageBox.Show("已删除"); 
            }else
            {
                MessageBox.Show("未找到符合条件的数据");
            }
        }

        /// <summary>
        /// 删除数据表
        /// </summary>
        /// <param name="table"></param>
        public void DelTable(string table)
        {
            bool flag = this.db.DbMaintenance.DropTable(table);
            if (flag)
            {
                MessageBox.Show("已删除");
            }
            else
            {
                MessageBox.Show("删除操作错误");
            }
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="data"></param>
        public void InsertData(string table, dynamic data)
        {
            string[] datas = data as string[];
            string dataString = "";
            foreach (var item in datas)
            {
                dataString += item;
            }
            string sql = "INSERT INTO @table VALUES (@data)";
            SugarParameter[] parameters =
            {
                new SugarParameter("@table", table),
                new SugarParameter("@data", dataString)
            };
            int flag = this.db.Ado.ExecuteCommand(sql, parameters);
            if (flag!=0)
            {
                MessageBox.Show("插入成功");
            }
            else
            {
                MessageBox.Show("插入失败");
            }
        }

        /// <summary>
        /// 新建表
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="columnInfos">表中的各列的信息</param>
        public void NewTable(string table, List<DbColumnInfo> columnInfos)
        {
            List<DbColumnInfo> dbColumnInfos = columnInfos;
            bool flag = this.db.DbMaintenance.CreateTable(table, dbColumnInfos);
            if (flag)
            {
                MessageBox.Show("新建成功");
            }
            else
            {
                MessageBox.Show("新建失败");
            }
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public DataTable QueryAll(string table)
        {
            string sql = "select * from @table";
            SugarParameter parameter = new SugarParameter("@table", table);
            return this.db.Ado.GetDataTable(sql, parameter);
            
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        /// <param name="table"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public DataTable QueryData(string table, string condition)
        {
            string sql = "select * from @table where @condition";
            SugarParameter[] parameters =
            {
                new SugarParameter("@table", table),
                new SugarParameter("@condition", condition)
            };
            return this.db.Ado.GetDataTable(sql, parameters);
        }
    }
}

