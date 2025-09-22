using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.Models {
    public class Game {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameID { get; set; }
        [Required]
        public string GameName { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public bool IsCompetive { get; set; }
        public bool IsCardGame { get; set; }
        public int AgeMinimum { get; set; }
        public enum Genre {
            Strategy,
            Family,
            Party,
            Abstract,
            DeckBuilding,
            Eurogame
        }

        public int Complexity { get; set; }

        public int AverageSession { get; set; }

        public ICollection<Collection> Collection { get; set; } = new List<Collection>();
        public virtual ICollection<Session> PlaySession { get; set; } = new List<Session>();

    }
}



