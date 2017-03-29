using LauncherDisplay.Controller.Interfaces;
using LauncherDisplay.Model;
using LauncherDisplay.View.Pages;

namespace LauncherDisplay.Controller
{
    public class LauncherController : IDisplayView
    {
        public MainWindow MainWindow { get; set; }
        public LauncherModel LauncherModel { get; set; }
        public LauncherController(MainWindow mainWindow, LauncherModel launcherModel)
        {
            MainWindow = mainWindow;
            LauncherModel = launcherModel;
        }

        public void DisplayView()
        {
            LauncherView launcherView = new LauncherView(MainWindow);
            launcherView.Display();
        }
    }
}
