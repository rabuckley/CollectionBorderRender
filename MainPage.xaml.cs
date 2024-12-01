namespace CollectionBorderRender;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		const int count = 50;
		Items = new(count);

		for (int i = 0; i < count; i++)
		{
			Items.Add($"Item {i}");
		}

		BindingContext = this;
	}

	public List<string> Items { get; }
}

