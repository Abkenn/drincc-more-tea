using Drincc.DAL.Models;

namespace Drincc.API.Contracts
{
    public interface ITeaService
    {
        public Task<List<Tea>> GetAllTeasAsync();
        public Task<Tea?> GetTeaByIdAsync(int id);
        public Task<Tea> AddTeaAsync(Tea request);
        public Task<Tea?> UpdateTeaAsync(int id, Tea request);
        public Task<Tea?> RemoveTeaAsync(int id);
    }
}
