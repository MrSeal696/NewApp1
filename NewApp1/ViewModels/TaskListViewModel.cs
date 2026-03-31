using System.Collections.ObjectModel;
using System.Windows.Input;
using NewApp1.Models;
using NewApp1.Services;

namespace NewApp1.ViewModels;

public class TaskListViewModel : BaseViewModel
{
    private readonly TaskRepository repo;

    public ObservableCollection<TaskItem> Tasks { get; set; } = new();

    public ICommand LoadCommand { get; }

    public TaskListViewModel(TaskRepository repository)
    {
        repo = repository;
        LoadCommand = new Command(async () => await Load());
    }

    private async Task Load()
    {
        Tasks.Clear();
        var items = await repo.GetAll();

        foreach (var item in items)
            Tasks.Add(item);
    }
}