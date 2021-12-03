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
            string response = await client.GetStringAsync("https://reqbin.com/echo/get/json");
            Console.WriteLine(response);
        }
        public async Task Run()
        {
            TempConsoleUI tempConsoleUI = new();
            tempConsoleUI.GetHttp();
        }
    }
}