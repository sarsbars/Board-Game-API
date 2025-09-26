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
        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateUser(CreateUserDTO UserDTO) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var user = _mapper.Map<User>(UserDTO);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var createdUserDTO = _mapper.Map<UserDTO>(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.UserID }, createdUserDTO);
        }

        //update
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> UpdateUser(int id, UserDTO userDTO) {
            if(id != userDTO.UserID) {
                return BadRequest();
            }
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var user = _mapper.Map<User>(userDTO);
            _context.Entry(user).State = EntityState.Modified;
            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!_context.Users.Any(e => e.UserID == id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return NoContent();
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser (int id) {
            var user = await _context.Users.FindAsync(id);
            if (user == null) {
                return NotFound();
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
