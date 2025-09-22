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

        public DateTime PlayDate { get; set; }
        public int LengthOfTime { get; set; }
        public string Summary { get; set; }

        public virtual Game Game { get; set; }

        public User Winner { get; set; }

        public virtual ICollection<Collection> Collection { get; set; } = new List<Collection>();
        public virtual ICollection<PlayParticipants> PlayParticpants { get; set; } = new List<PlayParticipants>();


    }
}
