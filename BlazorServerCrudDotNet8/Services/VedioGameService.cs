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

    public async Task<List<VideoGame>> GetAllVideoGamesAsync()
    {
        var reasult = await _context.VideoGames.ToListAsync();
        return reasult;
    }
}
