namespace AbsoluteLayoutApp.Modals;

public partial class NewPageModal : ContentPage
{
	public NewPageModal()
	{
		InitializeComponent();
	}

    private async void btnClose_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}