using BlazorServerCrudDotNet8.Models;

namespace BlazorServerCrudDotNet8.Services;

public interface IVideoGameService
{
    Task<List<VideoGame>> GetAllVideoGamesAsync();
    Task<VideoGame> GetVideoGameByIdAsync(int id);
    Task UpdateVideoGameAsync(VideoGame videoGame, int id);
    Task AddGameAsync(VideoGame videoGame);
    Task DeleteGameAsync(int id);
}
