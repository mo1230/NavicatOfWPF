using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NavicatOfWPF.Views;
using System.Windows.Controls;

namespace NavicatOfWPF.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private PagesManage pagesManage;
        private Page pages;
        public MainViewModel()
        {
            this.pagesManage = new PagesManage();
            this.pages = new FormPage();
            
            
        }

        public Page Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
                RaisePropertyChanged("Pages");
            }
        }

        public RelayCommand<string> MenuItemCommand
        {
            get{
                return new RelayCommand<string>((t) =>
                {
                    switch (t)
                    {
                        case "0":
                            Pages = new UsersPage();
                            break;
                        case "1":
                            Pages = new FormPage();
                            break;
                        case "2":
                            Pages = new ViewsPage();
                            break;
                        case "3":
                            Pages = new HanShuPage();
                            break;
                        case "4":
                            Pages = new EventPage();
                            break;
                        case "5":
                            Pages = new QueryPage();
                            break;
                        case "6":
                            Pages = new BaoBiaoPage();
                            break;
                        case "7":
                            Pages = new BeiFenPage();
                            break;
                        case "8":
                            Pages = new PlanPage();
                            break;
                        case "9":
                            Pages = new ModelPage();
                            break;
                        default:
                            break;
                    }
                });
            }
            
        }

        
    }
}