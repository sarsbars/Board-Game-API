using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.Models {
    public class Session {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SessionID { get; set; }

        [Required]
        [ForeignKey("Game")]
        public int GameID { get; set; }

        [Required]
        public DateTime PlayDate { get; set; }

        public int? LengthOfTime { get; set; }

        [StringLength(1000)]
        public string Summary { get; set; }

        [ForeignKey("Winner")]
        public int? WinnerID { get; set; }

        public virtual Game Game { get; set; }
        public virtual User Winner { get; set; }
        public virtual ICollection<PlayParticipant> PlayParticipants { get; set; } = new List<PlayParticipant>();
    }
}
