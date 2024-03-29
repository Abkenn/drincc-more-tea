﻿using Drincc.API.Contracts;
using Drincc.DAL.Data;
using Drincc.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Drincc.EF.Services
{
    public class TeaService : ITeaService
    {
        private readonly DataContext context;

        public TeaService(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Tea>> GetAllTeasAsync()
            => new List<Tea>(await context.Teas.ToListAsync());

        public async Task<Tea?> GetTeaByIdAsync(int id)
            => await context.Teas.FindAsync(id);

        public async Task<Tea> AddTeaAsync(Tea tea)
        {
            await context.Teas.AddAsync(tea);
            await context.SaveChangesAsync();
            return tea;
        }

        public async Task<Tea?> UpdateTeaAsync(int id, Tea request)
        {
            var tea = await GetTeaByIdAsync(id);

            if (tea != null)
            {
                tea.UpdateTeaDetails(name: request.Name);

                await context.SaveChangesAsync();
            }

            return tea;
        }

        public async Task<Tea?> RemoveTeaAsync(int id)
        {
            var tea = await GetTeaByIdAsync(id);

            if (tea != null)
            {
                context.Teas.Remove(tea);
                await context.SaveChangesAsync();
            }

            return tea;
        }
    }
}
