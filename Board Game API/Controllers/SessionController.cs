using AutoMapper;
using Board_Game_API.DTOS;
using Board_Game_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Board_Game_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase {
        private readonly BoardGameContext _context; private readonly IMapper _mapper;

        public SessionController (BoardGameContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        //Get all
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SessionDTO>>> GetSessions () {
            var sessions = await _context.Sessions.ToListAsync();
            var sessionDTOs = _mapper.Map<List<SessionDTO>>(sessions);
            return Ok(sessionDTOs);
        }

        //Get participants
        [HttpGet("{id}/PlayParticipants")]
        public async Task<ActionResult<IEnumerable<PlayParticipantDTO>>> GetParticipants(int id) {
            var session = await _context.Sessions.FindAsync(id);
            if(session == null) {
                return NotFound();
            }

            var playParticipants = await _context.PlayParticipants
                .Where(p => p.SessionID == id)
                .ToListAsync();

            var playParticipantDTOs = _mapper.Map<List<PlayParticipantDTO>>(playParticipants);
            return Ok(playParticipantDTOs);
        }

        //Create new

        //Add Participant

        //Delete
    }
}
