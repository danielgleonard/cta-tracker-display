using Microsoft.Extensions.Configuration;

namespace CTA_Tracker
{
    public partial class MainPage : ContentPage
    {
        static HttpClient client = new HttpClient();
        IConfiguration configuration;

        public MainPage(IConfiguration config)
        {
            configuration = config;

            InitializeComponent();

            ReadConfig();
        }

        public void AddLine(TransitLine line)
        {
            lines.RowDefinitions.Add(new RowDefinition());
            Grid.SetRow(line, lines.RowDefinitions.Count - 1);
            lines.Children.Add(line);
        }

        private void ReadConfig()
        {
            foreach (var configurationSection in configuration.GetRequiredSection("stations").GetChildren())
            {
                TransitLine requestedLine = configurationSection.Get<TransitLine>();
                requestedLine.httpClient = client;
                requestedLine.keyMetro = configuration.GetRequiredSection("keys").GetRequiredSection("metro").Value;
                requestedLine.keyBus = configuration.GetRequiredSection("keys").GetRequiredSection("bus").Value;

                AddLine(line: requestedLine);
            }
        }
    }

}
