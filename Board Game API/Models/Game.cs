using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.Models {
    public class Game { 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameID { get; set; }

        [Required]
        [StringLength(50)]
        public string GameName { get; set; }
        public enum Genre {
            Strategy,
            Family,
            Party,
            Abstract,
            Cooperative,
            DeckBuilding,
            Eurogame
        }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public bool IsCompetitive { get; set; }
        public bool IsCardGame { get; set; }
        public int? AgeMinimum { get; set; }

        [Required]
        public Genre GameGenre { get; set; }

        [Range(1, 5)]
        public int? Complexity { get; set; }

        public int? AverageSession { get; set; }

        public virtual ICollection<CollectionGame> CollectionGames { get; set; } = new List<CollectionGame>();
        public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
