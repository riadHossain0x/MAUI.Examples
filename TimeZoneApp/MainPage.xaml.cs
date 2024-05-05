namespace TimeZoneApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void btnDetails_Clicked(object sender, EventArgs e)
    {
        var dpText = dp.Date;
        var tpText = tp.Time;
        var pickerData = MyPicker.SelectedItem.ToString();

        lblDetails.Text = $"Date: {dpText}, Time: {tpText}, Location: {pickerData}";
    }
}
