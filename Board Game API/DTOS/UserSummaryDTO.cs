using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Board_Game_API.Models {
    public class UserSummaryDTO {
            public int UserID { get; set; }
            public string Username { get; set; }
    } 
}
