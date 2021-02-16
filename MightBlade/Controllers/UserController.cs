using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MightBlade.Data;
using MightBlade.Models;
using MightBlade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightBlade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private MBContext myDbContext;

        public UserController(UserService userService)
        {
            _userService = userService;
        }


        // Gets all users in the database

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<UserModel[]>> Get()
        {
            var users = (await _userService.GetUsersAsync()).Value;

            return Ok(users);
        }


        // gets a user in the database by guid

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserModel[]>> Get(Guid id)
        {
            var user = (await _userService.GetUserAsync(id)).Value;

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

    }
}
