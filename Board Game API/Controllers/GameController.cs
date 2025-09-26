using Board_Game_API.DTOS;
using Board_Game_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Board_Game_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase {
        private readonly BoardGameContext _context; private readonly IMapper _mapper;

        public GameController(BoardGameContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameDTO>>> GetGames() {
            var games = await _context.Games.ToListAsync();
            var gameDTOs = _mapper.Map<List<GameDTO>>(games);
            return Ok(gameDTOs);
        }

        // GET: api/games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameDTO>> GetGame(int id) {
            var game = await _context.Games.FindAsync(id);
            if (game == null) {
                return NotFound();
            }

            var gameDTO = _mapper.Map<GameDTO>(game);
            return Ok(gameDTO);
        }

        // POST: api/games
        [HttpPost]
        public async Task<ActionResult<GameDTO>> CreateGame(GameDTO gameDTO) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (gameDTO.GameID != 0) {
                ModelState.AddModelError("GameID", "GameID should not be specified; it is auto-generated.");
                return BadRequest(ModelState);
            }

            var game = _mapper.Map<Game>(gameDTO);
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            var createdGameDTO = _mapper.Map<GameDTO>(game);
            return CreatedAtAction(nameof(GetGame), new { id = game.GameID }, createdGameDTO);
        }
    }
}