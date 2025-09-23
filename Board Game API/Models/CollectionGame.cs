using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.Models {
    public class CollectionGame {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollectionGameID { get; set; }

        [Required]
        public int CollectionID { get; set; }

        [Required]
        public int GameID { get; set; }

        [StringLength(30)]
        public string Condition { get; set; }

        [Range(1, 10)]
        public int? PersonalRating { get; set; }

        public virtual Collection Collection { get; set; }
        public virtual Game Game { get; set; }
    }
}
