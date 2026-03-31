using NewApp1.Models;
using NewApp1.Services;

namespace NewApp1.Pages;

public partial class AddTaskPage : ContentPage
{
    private readonly TaskRepository repo;

    public AddTaskPage(TaskRepository repository)
    {
        InitializeComponent();
        repo = repository;
    }

    private async void OnSave(object sender, EventArgs e)
    {
        var task = new TaskItem
        {
            Title = title.Text,
            Description = desc.Text,
            DueDate = DateTime.Now
        };

        await repo.Save(task);
        await DisplayAlert("Ок", "Сохранено", "OK");
    }
}