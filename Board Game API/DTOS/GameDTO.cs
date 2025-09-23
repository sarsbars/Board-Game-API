namespace Board_Game_API.DTOS {
    public class GameDTO {

        public int GameID { get; set; }
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
    }
}
