using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Menu;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api")]
    [ApiController]
    public class MenuController : ControllerBase // provides a lightweight and easy-to-use foundation for creating APIs, handling HTTP requests and responses.
    {
        // This declares a private, read-only field to store the database context.
        private readonly ApplicationDBContext _context;

        // Constructor for the MenuController class
        public MenuController(ApplicationDBContext context)
        {
            // Assigns the injected database context (passed as a parameter) to the private field.
            _context = context;
        }

        [HttpGet]
        // IActionResult allows your method to return any kind of HTTP response. provides you with return Ok NotFound etc.
        public IActionResult GetAll()
        {
            // deferred execution query isn't run right away it waits until data is actually needed use ToList to execute query immediately
            var menus = _context.Menus.ToList()
            .Select(s => s.ToMenuDTO()); // .Select is just like a mapper a dotnet version of map returns a immutable array or list of ToMenuDTO 

            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var menu = _context.Menus.Find(id);

            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu.ToMenuDTO());
        }

        [HttpPost]
        // FromBody because the data will be saved as json file
        public IActionResult Post([FromBody] CreateMenuDTO menuDTO)
        {
            var menuModel = menuDTO.ToMenuFromCreateDTO();
            _context.Menus.Add(menuModel);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = menuModel.Id }, menuModel.ToMenuDTO());
        }
    }
}