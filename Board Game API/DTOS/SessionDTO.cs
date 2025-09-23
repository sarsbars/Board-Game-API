using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.DTOS {
    public class SessionDTO {
        public int SessionID { get; set; }

        [Required]
        [ForeignKey("Game")]
        public int GameID { get; set; }

        [Required]
        public DateTime PlayDate { get; set; }
    }
}
