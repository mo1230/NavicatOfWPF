using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavicatOfWPF.Views
{
    class PagesManage
    {
        private BaoBiaoPage baoBiaoPage;
        private BeiFenPage beiFenPage;
        private EventPage eventPage;
        private FormPage formPage;
        private HanShuPage hanShuPage;
        private ModelPage modelPage;
        private PlanPage planPage;
        private QueryPage queryPage;
        private UsersPage usersPage;
        private ViewsPage viewsPage;

        public BaoBiaoPage BaoBiaoPage { get => baoBiaoPage; set => baoBiaoPage = value; }
        public BeiFenPage BeiFenPage { get => beiFenPage; set => beiFenPage = value; }
        public EventPage EventPage { get => eventPage; set => eventPage = value; }
        public FormPage FormPage { get => formPage; set => formPage = value; }
        public HanShuPage HanShuPage { get => hanShuPage; set => hanShuPage = value; }
        public ModelPage ModelPage { get => modelPage; set => modelPage = value; }
        public PlanPage PlanPage { get => planPage; set => planPage = value; }
        public QueryPage QueryPage { get => queryPage; set => queryPage = value; }
        public UsersPage UsersPage { get => usersPage; set => usersPage = value; }
        public ViewsPage ViewsPage { get => viewsPage; set => viewsPage = value; }

        public PagesManage()
        {
            this.baoBiaoPage = new BaoBiaoPage();
            this.beiFenPage = new BeiFenPage();
            this.eventPage = new EventPage();
            this.formPage = new FormPage();
            this.hanShuPage = new HanShuPage();
            this.modelPage = new ModelPage();
            this.planPage = new PlanPage();
            this.queryPage = new QueryPage();
            this.usersPage = new UsersPage();
            this.viewsPage = new ViewsPage();
        }
    }
}
