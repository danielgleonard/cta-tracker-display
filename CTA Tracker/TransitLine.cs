namespace CTA_Tracker
{
    public class TransitLine : HorizontalStackLayout
    {
        public string Name;
        public Color Color;
        public string Station;
        public int Station_ID;
        public List<Arrival> Arrivals;

        public TransitLine()
        {
            
        }
    }
}