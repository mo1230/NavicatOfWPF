using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NavicatOfWPF.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static NavicatOfWPF.Db.DbManage;

namespace NavicatOfWPF.ViewModel
{
    class MysqlConnectionViewModel : ViewModelBase
    {
        private readonly Window window;
        private readonly PasswordBox passwordBox;
        public static  DbMySQL mysql;
        public MysqlConnectionViewModel(object obj, object objs)
        {
            this.window = obj as Window;
            this.passwordBox = objs as PasswordBox;

        }
       
        private string connectionName = string.Empty;
        public string ConnectionName
        {
            get
            {
                return connectionName;
            }
            set
            {
                connectionName = value;
                RaisePropertyChanged("ConnectionName");

            }

        }

        private string ip;
        public string Ip
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
                RaisePropertyChanged("Ip");
            }
        }

        private string port = string.Empty;
        public string Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
                RaisePropertyChanged("Port");
            }
        }

        private string username = string.Empty;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                RaisePropertyChanged("Username");
            }
        }

        private string password = string.Empty;
        public string Password
        {
            get { return password; }
            set 
            { 
                password = value; 
                RaisePropertyChanged("Password"); 
            }
        } 

        
        // 确认按钮的命令
        public RelayCommand EnsureBtnCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    // MessageBox.Show(ConnectionName);
                    mysql = DbMySQL.GetDbInstance(this.Ip, this.Username, this.Password);
                    this.window.Close();
                    
                    
                });
            }
        }

        // 取消按钮的命令
        public RelayCommand CancelBtnCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    this.window.Close();
                });
            }
        }
    }
}
