using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Menu;
using api.Interfaces;
using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class MenuRepository : IMenuRepository // plugin the IMenuRepository
    {
        // A constructor is a special method in a class that is automatically called when an instance of the class is created.
        // It is used to initialize the class's properties or perform setup tasks.
        // What is Happening Here?
        // The MenuRepository class has a private field _context of type ApplicationDBContext.
        // The constructor accepts a parameter context of type ApplicationDBContext.
        // This context parameter is assigned to the _context field to make the database context available throughout the class.
        private readonly ApplicationDBContext _context; // when is initialized it stores it here

        // Dependency Injection (DI) is a design pattern in which a class does not create its own dependencies but instead receives them from an external source. In your case, the MenuRepository class does not create its own instance of ApplicationDBContext; instead, the dependency (the ApplicationDBContext) is "injected" into the class.
        public MenuRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Menu> CreateAsync(Menu menuModel)
        {
            await _context.Menus.AddAsync(menuModel);
            await _context.SaveChangesAsync();
            return menuModel;
        }

        public async Task<Menu?> DeleteAsync(int id)
        {
            var menuModel = await _context.Menus.FirstOrDefaultAsync(x => x.Id == id);

            if (menuModel == null)
            {
                return null;
            }

            _context.Menus.Remove(menuModel);
            await _context.SaveChangesAsync();
            return menuModel;
        }

        public async Task<List<Menu>> GetAllAsync()
        {
            return await _context.Menus.ToListAsync();
        }

        public async Task<Menu?> GetByIdAsync(int id)
        {
            return await _context.Menus.FindAsync(id);
        }

        public async Task<Menu?> UpdateAsync(int id, UpdateMenuDTO menuDTO)
        {
            var existingMenu = await _context.Menus.FirstOrDefaultAsync(x => x.Id == id);

            if (existingMenu == null)
            {
                return null;
            }

            existingMenu.Name = menuDTO.Name;
            existingMenu.Description = menuDTO.Description;
            existingMenu.Category = menuDTO.Category;
            existingMenu.Description = menuDTO.Description;
            existingMenu.ImageUrl = menuDTO.ImageUrl;

            await _context.SaveChangesAsync();
            return existingMenu;
        }
    }
}