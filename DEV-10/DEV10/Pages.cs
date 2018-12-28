using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV10
{
    public static class Pages
    {
        public static LoginPage LoginPage
        {
            get
            {
                var loginPage = new LoginPage();
                return loginPage;
            }
        }

        public static StartPage StartPage
        {
            get
            {
                var startPage = new StartPage();
                return startPage;
            }
        }

        public static RoutePage RoutePage
        {
            get
            {
                var routePage = new RoutePage();
                return routePage;
            }
        }
    }
}
