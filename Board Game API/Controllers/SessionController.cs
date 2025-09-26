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

        //Get One
        [HttpGet("{id}")]
        public async Task<ActionResult<SessionDTO>> GetSession(int id) {
            var session = await _context.Sessions.FindAsync(id);
            if(session == null) {
                return NotFound();
            }

            var sessionDTO = _mapper.Map<SessionDTO>(session);
            return Ok(sessionDTO);
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
        [HttpPost]
        public async Task<ActionResult<SessionDTO>> CreateSession(SessionDTO sessionDTO) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if(sessionDTO.SessionID != 0) {
                ModelState.AddModelError("SessionID", "SessionID should not be specified; It is auto-generated.");
                return BadRequest(ModelState);
            }

            var session = _mapper.Map<Session>(sessionDTO);
            _context.Sessions.Add(session);
            await _context.SaveChangesAsync();

            var createdSessionDTO = _mapper.Map<SessionDTO>(session);
            return CreatedAtAction(nameof(GetSession), new { id = session.SessionID }, createdSessionDTO);
        }

        //Add Participant

        //Delete
    }
}
