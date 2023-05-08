namespace ScrollViewSample;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}


    private async void WorksButton_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Works());
    }

    private async void FailButton_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Fails());
    }
}

