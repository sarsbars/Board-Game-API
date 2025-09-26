using Board_Game_API.Models;
using System.ComponentModel.DataAnnotations;

namespace Board_Game_API.DTOS {
    public class GameDTO {
        public int GameID { get; set; }

        [Required]
        [StringLength(50)]
        public string GameName { get; set; }

        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public bool IsCompetitive { get; set; }
        public bool IsCardGame { get; set; }
        public int? AgeMinimum { get; set; }

        [Required]
        [EnumDataType(typeof(Game.Genre))]
        public Game.Genre Genre { get; set; }

        [Range(1, 5)]
        public int? Complexity { get; set; }

        public int? AverageSession { get; set; }
    }
}