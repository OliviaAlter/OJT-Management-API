using System.Collections.Generic;
using System.Threading.Tasks;
using API.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ojt_management_api.Data;
using ojt_management_api.Entities;

namespace ojt_management_api.Controllers;

public class UsersController : BaseApiController
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    //api/users/{id}
    [Authorize]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Users>> GetUser(int id)
    {
        return (await _context.Users.FindAsync(id))!;
    }
}