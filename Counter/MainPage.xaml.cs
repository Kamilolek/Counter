using Counter.Models;
using System.Collections.ObjectModel;

namespace Counter;

public partial class MainPage : ContentPage
{
	public static readonly BindableProperty CounterElementsProperty = BindableProperty.Create(
		nameof(CounterElements),
		typeof(ObservableCollection<CounterElementModel>),
		typeof(MainPage),
		new ObservableCollection<CounterElementModel>()
		);
	public ObservableCollection<CounterElementModel> CounterElements
	{
        get => (ObservableCollection<CounterElementModel>)GetValue(CounterElementsProperty);
        set => SetValue(CounterElementsProperty, value);
    }

	public MainPage()
	{
		InitializeComponent();
		CounterElements.Add(new CounterElementModel { Count = 0, Description = "Licznik" });

	}

    private void Add_Clicked(object sender, EventArgs e)
    {
        CounterElements.Add(new CounterElementModel { Count = 0, Description = "Licznik" });

    }
}

