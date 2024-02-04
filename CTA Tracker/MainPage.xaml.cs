namespace CTA_Tracker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void AddLine(TransitLine line)
        {
            verticalStack.Children.Add(line)
        }
    }

}
