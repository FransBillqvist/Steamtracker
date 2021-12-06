using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Steamtracker
{
    public class TempConsoleUI
    {
        HttpClient client = new();
        public async Task GetHttp()
        {
            ApiKey apiKey = new();
            string newurl = apiKey.GetApiKey("http://api.steampowered.com/IPlayerService/GetRecentlyPlayedGames/v0001/?key=XXXXXXXXXXXXXXXXX&steamid=76561198150027303&format=json"); 
            string response = await client.GetStringAsync(newurl);
            Console.WriteLine(response);
        }
        public async Task Run()
        {
            TempConsoleUI tempConsoleUI = new();
            tempConsoleUI.GetHttp();
        }
    }
}