using BasicApp.Handlers;

namespace BasicApp;

public partial class App : Application
{
    const int WindowHeight = 800;
    const int WindowWidth = 400;
    public App()
    {
        InitializeComponent();
        WindowHandler.Handler(WindowWidth, WindowHeight);
        MainPage = new AppShell();
    }
}
