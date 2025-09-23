using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.DTOS {
    public class PlayParticipantDTO {
        public int ParticipantID { get; set; }

        [Required]
        [ForeignKey("Session")]
        public int SessionID { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }

        public int? Score { get; set; }
        public bool IsWinner { get; set; }

    }
}
