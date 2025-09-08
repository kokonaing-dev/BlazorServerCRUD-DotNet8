using BlazorServerCrudDotNet8.Data;
using BlazorServerCrudDotNet8.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrudDotNet8.Services;

public class MenuService : IMenuService
{
    private readonly DataContext _context;

    public MenuService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Menu>> GetMenusAsync()
    {
        return await _context.Menus
            .OrderBy(m => m.Id) // or custom ordering column
            .ToListAsync();
    }

}
