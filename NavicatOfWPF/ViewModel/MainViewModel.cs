using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NavicatOfWPF.Views;

namespace NavicatOfWPF.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private UsersPage usersPage;

        public UsersPage UsersPage
        {
            get
            {
                return this.usersPage;
            }
            set
            {
                this.usersPage = value;
            }
        }
        public MainViewModel()
        {
            this.usersPage = new UsersPage();   
        }

        public RelayCommand<string> MenuItemComman
        {
            get{
                return new RelayCommand<string>((t) =>
                {
                   
                });
            }
            
        }
    }
}