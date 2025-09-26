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

        [HttpGet ("{collectionGameId}")]
        public async Task<ActionResult<CollectionGame>> GetCollectionGame(int collectionGameId) {
            var collectionGame = await _context.CollectionGames.FindAsync(collectionGameId);
            if(collectionGame == null) {
                return NotFound();
            }

            var collectionGameDTO = _mapper.Map<CollectionGameDTO>(collectionGame);
            return Ok(collectionGameDTO);
        }

        //Add CollectionGame
        [HttpPost]
        public async Task<ActionResult<CreateCollectionGameDTO>> AddCollectionGame (CreateCollectionGameDTO cgDTO) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var collection = await _context.Collections.FindAsync(cgDTO.CollectionID);
            var game = await _context.Games.FindAsync(cgDTO.GameID);
            if (collection == null || game == null) {
                return NotFound();
            }

            var collectionGame = _mapper.Map<CollectionGame>(cgDTO);
            _context.CollectionGames.Add(collectionGame);
            await _context.SaveChangesAsync();

            var createdCollectionGameDTO = _mapper.Map<CreateCollectionGameDTO>(collectionGame);
            return CreatedAtAction(nameof(GetCollectionGame), new { collectionGameId = collectionGame.CollectionGameID }, createdCollectionGameDTO);
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
