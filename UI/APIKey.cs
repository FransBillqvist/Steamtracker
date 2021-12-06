using System.IO;
using System.Net.Http;
using System.Net;
public class ApiKey
{
    private string key = System.IO.File.ReadAllText(@"./APIKEY.rtf");

    public ApiKey()
    {
        HttpClient httpClient = new();
        httpClient.DefaultRequestHeaders.Add("ApiKey", key);
    }
    public string GetApiKey(string requestedUrl)
    {
      string urlWithApi =  requestedUrl.Replace("?key=XXXXXXXXXXXXXXXXX&steamid=", "?key="+key+"&steamid=");
      return urlWithApi;
    }
}