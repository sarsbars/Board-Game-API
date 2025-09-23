using System.ComponentModel.DataAnnotations;

namespace Board_Game_API.DTOS {
    public class CollectionGameDTO {
        public int CollectionGameID { get; set; }

        [Required]
        public int CollectionID { get; set; }

        [Required]
        public int GameID { get; set; }
    }
}
