using System.ComponentModel.DataAnnotations;

namespace Board_Game_API.DTOS {
    public class CreateCollectionGameDTO {
        [Required]
        public int CollectionID { get; set; }

        [Required]
        public int GameID { get; set; }

        [StringLength(30)]
        public string Condition { get; set; }
    }
}
