namespace CTA_Tracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            TransitLine testline = new TransitLine { Name = "Red", Color = Colors.Coral, Station_ID = 30274 };

            MainPage.AddLine(testline);
        }
    }
}
