namespace BasicApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void btnApply_Clicked(object sender, EventArgs e)
    {
        this.txtDescription.Text = "New Description!";
    }
}
