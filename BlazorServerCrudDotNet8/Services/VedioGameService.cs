using BlazorServerCrudDotNet8.Data;
using BlazorServerCrudDotNet8.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BlazorServerCrudDotNet8.Services;

public class VedioGameService : IVideoGameService
{

    private readonly DataContext _context;

    public VedioGameService(DataContext context)
    {
        _context = context;
    }

    public async Task AddGameAsync(VideoGame videoGame)
    {
        _context.VideoGames.Add(videoGame);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteGameAsync(int id)
    {
        var DbGame = await _context.VideoGames.FindAsync(id);
        if (DbGame != null)
        {
            _context.Remove(DbGame);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<List<VideoGame>> GetAllVideoGamesAsync()
    {
        var reasult = await _context.VideoGames.ToListAsync();
        return reasult;
    }

    public async Task<VideoGame> GetVideoGameByIdAsync(int id)
    {
        return await _context.VideoGames.FindAsync(id);
    }

    public async Task UpdateVideoGameAsync(VideoGame videoGame, int id)
    {
        var dbGame = await _context.VideoGames.FindAsync(id);
        if (dbGame != null)
        {
            dbGame.Title = videoGame.Title;
            dbGame.Publisher = videoGame.Publisher;
            dbGame.ReleaseYear = videoGame.ReleaseYear;
            await _context.SaveChangesAsync();
        }
    }
}
