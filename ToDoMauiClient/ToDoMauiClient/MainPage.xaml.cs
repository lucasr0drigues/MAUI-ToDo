using ToDoMauiClient.DataServices;

namespace ToDoMauiClient;

public partial class MainPage : ContentPage
{
	private readonly IRestDataService _dataService;

	public MainPage(IRestDataService dataService)
	{
		InitializeComponent();

		_dataService = dataService;
	}

	protected async override void OnAppearing()
	{
        Console.WriteLine("---> Getting ToDos");
        base.OnAppearing();

		collectionView.ItemsSource = await _dataService.GetAllToDosAsync();
	}

	async void OnAddToDoClicked(object sender, EventArgs e)
	{
		Console.WriteLine("---> Add button clicked");
	}

	async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
        Console.WriteLine("---> Item changed clicked");
    }
}

