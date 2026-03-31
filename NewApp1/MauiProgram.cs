using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using NewApp1.Pages;
using NewApp1.Services;
using NewApp1.ViewModels;

namespace NewApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "tasks.db");

        builder.Services.AddSingleton(new TaskRepository(dbPath));
        builder.Services.AddTransient<TaskListViewModel>();

        builder.Services.AddTransient<TaskListPage>();
        builder.Services.AddTransient<AddTaskPage>();
        builder.Services.AddTransient<ReportsPage>();
        builder.Services.AddTransient<SettingsPage>();

        return builder.Build();
    }
}