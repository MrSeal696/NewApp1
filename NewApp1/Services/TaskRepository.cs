using SQLite;
using NewApp1.Models;

namespace NewApp1.Services;

public class TaskRepository
{
    private readonly SQLiteAsyncConnection db;

    public TaskRepository(string path)
    {
        db = new SQLiteAsyncConnection(path);
        db.CreateTableAsync<TaskItem>().Wait();
    }

    public Task<List<TaskItem>> GetAll() => db.Table<TaskItem>().ToListAsync();

    public Task<int> Save(TaskItem task)
    {
        if (task.Id != 0)
            return db.UpdateAsync(task);

        return db.InsertAsync(task);
    }

    public Task<int> Delete(TaskItem task) => db.DeleteAsync(task);
}