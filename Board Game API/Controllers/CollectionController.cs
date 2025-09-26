using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Board_Game_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase {
        private readonly BoardGameContext _context; private readonly IMapper _mapper;

        public CollectionController (BoardGameContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        //Get Collections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollectionDTO>>> GetCollections() {
            var collections = await _context.Collections.ToListAsync();
            var collectionDTOs = _mapper.Map<List<CollectionDTO>>(collections);
            return Ok(collectionDTOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CollectionDTO>> GetCollection (int id) {
            var collection = await _context.Collections.FindAsync(id);
            if (collection == null) {
                return NotFound();
            }

            var collectionDTO = _mapper.Map<CollectionDTO>(collection);
            return Ok(collectionDTO);
        }

        //Get CollectionGames
        [HttpGet("{id}/CollectionGames")]
        public async Task<ActionResult<List<CollectionGameDTO>>> GetCollectionGames (int id) {
            var collection = await _context.Collections.FindAsync(id);
            if (collection == null) {
                return NotFound();
            }

            var collectionGames = await _context.CollectionGames
                .Where(c => c.CollectionID == id)
                .ToListAsync();

            var collectionGameDTOs = _mapper.Map<List<CollectionGameDTO>>(collectionGames);
            return Ok(collectionGameDTOs);
        }

        [HttpGet ("CollectionGames/{id}")]
        public async Task<ActionResult<CollectionGame>> GetCollectionGame(int id) {
            var collectionGame = await _context.CollectionGames.FindAsync(id);
            if(collectionGame == null) {
                return NotFound();
            }

            var collectionGameDTO = _mapper.Map<CollectionGameDTO>(collectionGame);
            return Ok(collectionGameDTO);
        }

        //Add CollectionGame
        [HttpPost("CollectionGame")]
        public async Task<ActionResult<CollectionGameDTO>> AddCollectionGame (CollectionGameDTO cgDTO) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var collection = await _context.Collections.FindAsync(cgDTO.CollectionID);
            var game = await _context.Games.FindAsync(cgDTO.GameID);
            if (collection == null || game == null) {
                return NotFound();
            }

            if (cgDTO.CollectionGameID != 0) {
                ModelState.AddModelError("CollectionGameID", "CollectionGameID should not be specified; It is auto-generated.");
                return BadRequest(ModelState);
            }

            var collectionGame = _mapper.Map<CollectionGame>(cgDTO);
            _context.CollectionGames.Add(collectionGame);
            await _context.SaveChangesAsync();

            var createdCollectionGameDTO = _mapper.Map<CollectionGameDTO>(collectionGame);
            return CreatedAtAction(nameof(GetCollectionGame), new { id = collectionGame.CollectionGameID }, createdCollectionGameDTO);
        }

        //Delete Collection
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollection (int id) {
            var collection = await _context.Collections.FindAsync(id);
            if (collection == null) {
                return NotFound();
            }
            _context.Collections.Remove(collection);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
