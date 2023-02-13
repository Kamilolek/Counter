namespace Counter.Views.Containers;

public partial class CounterElement : ContentView
{
    public static readonly BindableProperty CountProperty = BindableProperty.Create(
        nameof(Count),
        typeof(int),
        typeof(CounterElement),
        0
        );
    public int Count
    {
        get => (int)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
        nameof(Description),
        typeof(string),
        typeof(CounterElement),
        string.Empty
        );
    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

	public CounterElement()
	{
		InitializeComponent();
	}

    private void Minus_Clicked(object sender, EventArgs e)
    {
        if (Count > 0)
        {
            Count--;
        }
    }

    private void Plus_Clicked(object sender, EventArgs e)
    {
        Count++;
    }
}