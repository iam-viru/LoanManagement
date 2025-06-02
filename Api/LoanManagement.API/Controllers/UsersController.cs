using LoanManagement.Application.DTOs;
using LoanManagement.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoanManagement.API.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RegisterRequest request)
        {
            await _userService.CreateAsync(request);
            return Ok("User created.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserDto dto)
        {
            await _userService.UpdateAsync(id, dto);
            return Ok("User updated.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _userService.DeleteAsync(id);
            return Ok("User deleted.");
        }
    }
}
