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

        // GET: api/Session
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SessionDTO>>> GetSessions () {
            var sessions = await _context.Sessions.ToListAsync();
            var sessionDTOs = _mapper.Map<List<SessionDTO>>(sessions);
            return Ok(sessionDTOs);
        }

        // GET: api/Session/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SessionDTO>> GetSession(int id) {
            var session = await _context.Sessions.FindAsync(id);
            if(session == null) {
                return NotFound();
            }

            var sessionDTO = _mapper.Map<SessionDTO>(session);
            return Ok(sessionDTO);
        }

        // GET: /api/Session/PlayParticipants/{id}
        [HttpGet("PlayParticipants/{id}")]
        public async Task<ActionResult<SessionDTO>> GetPlayParticipant (int id) {
            var playParticipant = await _context.PlayParticipants.FindAsync(id);
            if (playParticipant == null) {
                return NotFound();
            }

            var ppDTO = _mapper.Map<PlayParticipantDTO>(playParticipant);
            return Ok(ppDTO);
        }

        // GET: /api/Session/{id}/PlayParticipants
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

        // POST: /api/Session
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

        // POST: /api/Session/PlayParticipant
        [HttpPost("PlayParticipants")]
        public async Task<ActionResult<PlayParticipantDTO>> AddPlayParticipant (PlayParticipantDTO ppDTO) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var session = await _context.Sessions.FindAsync(ppDTO.SessionID);
            var user = await _context.Users.FindAsync(ppDTO.UserID);
            if(session == null || user == null) {
                return NotFound();
            }

            if (ppDTO.ParticipantID != 0) {
                ModelState.AddModelError("ParticipantID", "ParticipantID should not be specified; It is auto-generated.");
                return BadRequest(ModelState);
            }

            var playParticipant = _mapper.Map<PlayParticipant>(ppDTO);
            _context.PlayParticipants.Add(playParticipant);
            await _context.SaveChangesAsync();

            var createdPPDTO = _mapper.Map<PlayParticipantDTO>(playParticipant);
            return CreatedAtAction(nameof(GetPlayParticipant), new {id = playParticipant.ParticipantID }, createdPPDTO);
        }

        // PUT: /api/Session/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<SessionDTO>> UpdateSession(int id, SessionDTO sessionDTO) {
            if (id != sessionDTO.SessionID) {
                return BadRequest();
            }

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var session = _mapper.Map<Session>(sessionDTO);
            _context.Entry(session).State = EntityState.Modified;
            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!_context.Sessions.Any(e => e.SessionID == id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return Ok(sessionDTO);
        }

        // DELETE: /api/Session/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser (int id) {
            var session = await _context.Sessions.FindAsync(id);
            if (session == null) {
                return NotFound();
            }
            _context.Sessions.Remove(session);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
