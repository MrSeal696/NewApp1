using System.Net.Http.Json;

namespace NewApp1.Services.Api;

public class TaskApiService
{
    private readonly HttpClient client;

    public TaskApiService()
    {
        client = new HttpClient
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com/")
        };
    }

    public async Task<List<TaskDto>> GetTasks()
    {
        var data = await client.GetFromJsonAsync<List<TaskDto>>("todos");
        return data ?? new List<TaskDto>();
    }
}