using System.Globalization;
using AppIII.Maui.ViewModel;

namespace AppIII.Maui;

public sealed partial class App : Application
{
    public App(AppShellViewModel viewModel)
    {
        InitializeComponent();
        string culture = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

        Thread.CurrentThread.CurrentUICulture = culture == "da" ? new CultureInfo("da") : new CultureInfo("en");
        MainPage = new AppShell(viewModel);
    }
}