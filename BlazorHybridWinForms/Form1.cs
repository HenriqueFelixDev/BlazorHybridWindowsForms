using BlazorHybridWinForms.Components;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace BlazorHybridWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        var services = new ServiceCollection();
        ConfigureServices(services);

        blazorWebView1.HostPage = @"wwwroot\index.html";
        blazorWebView1.Services = services.BuildServiceProvider();
        blazorWebView1.RootComponents.Add<App>("#app");
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        services.AddWindowsFormsBlazorWebView();
        services.AddMudServices();
    }
}
