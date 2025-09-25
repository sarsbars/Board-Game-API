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
        //Get Collection by ID
        //Get Collection by UserID
        //Create Collection
        //Add to Collection (Update)
        //Delete Collection
    }
}
