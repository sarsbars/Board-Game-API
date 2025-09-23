using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.Models {
    public class PlayParticipant {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParticipantID { get; set; }

        [Required]
        [ForeignKey("Session")]
        public int SessionID { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }

        public int? Score { get; set; }
        public bool IsWinner { get; set; }

        public virtual Session Session { get; set; }
        public virtual UserSummaryDTO User { get; set; }
    }
}
