using Newtonsoft.Json;
using System.Text;

namespace OriontekMVC.Models
{
    public class RequestAPI<T>
    {
        private HttpRequestMessage httpRequest = new HttpRequestMessage();
        public RequestAPI(HttpMethod method, string url, T? content) 
        {
            httpRequest.Method = method;
            httpRequest.RequestUri = new Uri(url);
            if (content != null)
            {
                var myContent = JsonConvert.SerializeObject(content);
                var stringContent = new StringContent(myContent, UnicodeEncoding.UTF8, "application/json");
                httpRequest.Content = stringContent;
            }
        }
        public async Task<IEnumerable<T>?> RequestAPIListAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(httpRequest);
                string textResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(textResult);
            }
        }

        public async Task<T?> RequestAPISingleAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(httpRequest);
                string textResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(textResult);
            }
        }

        public async Task<string> RequestAPIAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(httpRequest);
                string textResult = await response.Content.ReadAsStringAsync();
                return textResult;
            }
        }
    }
}
