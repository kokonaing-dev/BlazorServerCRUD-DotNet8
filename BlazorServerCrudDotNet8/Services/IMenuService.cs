using BlazorServerCrudDotNet8.Models;

namespace BlazorServerCrudDotNet8.Services
{
    public interface IMenuService
    {
        Task<List<Menu>> GetMenusAsync();
    }
}
