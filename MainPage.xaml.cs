namespace CollectionBorderRender;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		Items = [];

		for (int i = 0; i < 25; i++)
		{
			Items.Add($"Item {i}");
		}

		BindingContext = this;
	}

	public List<string> Items { get; }
}

