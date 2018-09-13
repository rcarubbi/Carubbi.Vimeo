using Carubbi.Vimeo.ResponseModels;
using Newtonsoft.Json;
using System.Net;

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

        public QueryRootObject Query(string term, int page = 1)
        {
            using (var wc = new WebClient())
            {
                var json = wc.DownloadString($"{BASE_API}videos/?query={term}&access_token={_accessToken}&page={page}");
                var response = JsonConvert.DeserializeObject<QueryRootObject>(json);
                return response;
            }
        }

        public VideoRootObject Video(long videoId)
        {
            using (var wc = new WebClient())
            {
                var json = wc.DownloadString($"{BASE_API}videos/{videoId}&access_token={_accessToken}");
                var response = JsonConvert.DeserializeObject<VideoRootObject>(json);
                return response;
            }
        }

        public string GetDownloadLink(long videoId)
        {
            return Video(videoId).download[0].link;
        }
    }
}