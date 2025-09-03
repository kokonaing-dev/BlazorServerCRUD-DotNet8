using BlazorServerCrudDotNet8.Models;

namespace BlazorServerCrudDotNet8.Services;

public interface IVideoGameService
{
    Task<List<VideoGame>> GetAllVideoGamesAsync();
}
