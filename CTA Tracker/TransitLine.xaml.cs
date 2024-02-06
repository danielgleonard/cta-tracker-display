namespace CTA_Tracker;

public partial class TransitLine : ContentView
{
    public string? Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
    public static readonly BindableProperty NameProperty =
        BindableProperty.Create(nameof(Name), typeof(string), typeof(TransitLine));
    
    public string? Heading
    {
        get => (string)GetValue(HeadingProperty);
        set => SetValue(HeadingProperty, value);
    }
    public static readonly BindableProperty HeadingProperty =
        BindableProperty.Create(nameof(Heading), typeof(string), typeof(TransitLine));

    public Color? Color
    {
        get => (Color)GetValue(ColorProperty);
        set => SetValue(ColorProperty, value);
    }
    public static readonly BindableProperty ColorProperty =
        BindableProperty.Create(nameof(Color), typeof(Color), typeof(TransitLine));

    public string? Station
    {
        get => (string)GetValue(StationProperty);
        set => SetValue(StationProperty, value);
    }
    public static readonly BindableProperty StationProperty =
        BindableProperty.Create(nameof(Station), typeof(string), typeof(TransitLine));

    public int? Station_ID
    {
        get => (int)GetValue(Station_IDProperty);
        set => SetValue(Station_IDProperty, value);
    }
    public static readonly BindableProperty Station_IDProperty =
        BindableProperty.Create(nameof(Station_ID), typeof(int), typeof(TransitLine));

    public string? Mode
    {
        get => (string)GetValue(ModeProperty);
        set => SetValue(ModeProperty, value);
    }
    public static readonly BindableProperty ModeProperty =
        BindableProperty.Create(nameof(Mode), typeof(string), typeof(TransitLine));

    public List<Arrival> Arrivals
    {
        get => (List<Arrival>)GetValue(ArrivalsProperty);
        set => SetValue(ArrivalsProperty, value);
    }
    public static readonly BindableProperty ArrivalsProperty =
        BindableProperty.Create(nameof(Arrivals), typeof(List<Arrival>), typeof(TransitLine));

    public string Arrival0
    {
        get => Arrivals[0].Minutes.HasValue ? Convert.ToString(Arrivals[0].Minutes) : "??";
    }
    public static readonly BindableProperty Arrival0Property =
        BindableProperty.Create(nameof(Arrival0), typeof(string), typeof(TransitLine));
    
    public string Arrival1
    {
        get => Arrivals[1].Minutes.HasValue ? Convert.ToString(Arrivals[1].Minutes) : "??";
    }
    public static readonly BindableProperty Arrival1Property =
        BindableProperty.Create(nameof(Arrival1), typeof(string), typeof(TransitLine));
    
    public string Arrival2
    {
        get => Arrivals[2].Minutes.HasValue ? Convert.ToString(Arrivals[2].Minutes) : "??";
    }
    public static readonly BindableProperty Arrival2Property =
        BindableProperty.Create(nameof(Arrival2), typeof(string), typeof(TransitLine));

    public TransitLine()
    {
        Arrivals = [new Arrival(), new Arrival(), new Arrival()];

        InitializeComponent();
    }
}