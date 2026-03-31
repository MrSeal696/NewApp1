using NewApp1.ViewModels;

namespace NewApp1.Pages;

public partial class TaskListPage : ContentPage
{
    public TaskListPage(TaskListViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}