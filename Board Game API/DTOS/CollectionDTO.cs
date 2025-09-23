using System.ComponentModel.DataAnnotations;

namespace Board_Game_API.DTOS {
    public class CollectionDTO {
        public int CollectionID { get; set; }

        [Required]
        public int UserID { get; set; }
    }
}
