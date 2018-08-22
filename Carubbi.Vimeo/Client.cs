using System.Net;
using Newtonsoft.Json;

namespace Carubbi.Vimeo
{
    public class Client
    {
        private const string BASE_API = "https://api.vimeo.com/";
        private readonly string _accessToken;

        public Client(string accessToken)
        {
            _accessToken = accessToken;
        }

        public string GetDownloadLink(long videoId)
        {
            using (var wc = new WebClient())
            {
                var json = wc.DownloadString($"{BASE_API}videos/{videoId}?access_token={_accessToken}");
                dynamic obj = JsonConvert.DeserializeObject(json);
                return obj.download[0].link;
            }
        }
    }
}