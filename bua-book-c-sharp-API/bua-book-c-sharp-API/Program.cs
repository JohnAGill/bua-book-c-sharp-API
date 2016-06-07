using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace bua_book_c_sharp_API
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://dev-api.buabook.com/");
            RestRequest request = new RestRequest("api/players?user_id=0&token=00000000-0000-0000-0000-000000000000", Method.GET);
            PlayersResponse queryResult = client.Execute<PlayersResponse>(request).Data;
            List<Player> players = queryResult.GetPlayers();
            Player ozil = players.Find((p) => p.ticker == "OZL.AR");
            Console.WriteLine(ozil.name);
            System.Threading.Thread.Sleep(5000);
        }
    }
}
