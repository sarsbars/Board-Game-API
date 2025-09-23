using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.Models {
    public class Collection {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CollectionID { get; set; }

        [Required]
        public int UserID { get; set; }

        public virtual UserSummaryDTO User { get; set; }
        public virtual ICollection<CollectionGame> CollectionGames { get; set; } = new List<CollectionGame>();
    }
}
