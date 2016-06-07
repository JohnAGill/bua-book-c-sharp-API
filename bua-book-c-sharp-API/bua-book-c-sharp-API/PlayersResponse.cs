using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bua_book_c_sharp_API
{
    public class PlayersResponse
    {
        public PlayersResponse1 response { get; set; }

        public List<Player> GetPlayers()
        {
            return response.players;
        }
    }

    public class PlayersResponse1
    {
        public List<Player> players { get; set; }
    }

    public class Player
    {
        public string ticker { get; set; }

        public int player_id { get; set; }

        public string name { get; set; }
    }
}
