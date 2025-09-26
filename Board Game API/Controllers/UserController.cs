using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Board_Game_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {

        private readonly BoardGameContext _context; private readonly IMapper _mapper;
        public UserController (BoardGameContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        //get all
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers () {
            var users = await _context.Users.ToListAsync();
            var userDTOs = _mapper.Map<List<UserDTO>>(users);
            return Ok(userDTOs);
        }

        //get one
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUser(int id) {
            var user = await _context.Users.FindAsync(id);
            var userDTO = _mapper.Map<UserDTO>(user);
            return Ok(userDTO);
        }
        //create
        //update
        //delete


    }
}
