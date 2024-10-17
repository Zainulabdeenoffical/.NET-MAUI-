namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeComponent();

            //  var flexLayoutPage = new FlexLayoutxaml();
            var presenatationcontrol = new presentationconrtrol();
           
           //var absoultepage = new absolutelayout(); 
           // var gridpage = new gridpage();
           // var stackpage = new stackpage();
           // var flayoutpage = new Flyout();
           // var tabbedpage = new newtabbedpage();
           // var   Navpage   =   new NavigationPage(new MainPage());
           // Navpage.BarBackgroundColor = Colors.Gold;
           // Navpage.BarTextColor = Colors.White;
            MainPage = presenatationcontrol;
        }
    }
}
