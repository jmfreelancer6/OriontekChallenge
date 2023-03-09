using API.Dtos;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace OriontekMVC.Models
{
    public class RequestAPI
    {
        public static async Task<IEnumerable<ClienteContactoDto>?> GetAPIAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(url);
                var response = await client.GetAsync(uri);
                string textResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<ClienteContactoDto>>(textResult);
            }
        }
        public static async Task<ClienteContactoDto?> GetOneAPIAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(url);
                var response = await client.GetAsync(uri);
                string textResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ClienteContactoDto>(textResult);
            }
        }
        public static async Task<string> PostAPIAsync(string url, ClienteContactoDto content)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(url);
                var myContent = JsonConvert.SerializeObject(content);
                var stringContent = new StringContent(myContent, UnicodeEncoding.UTF8, "application/json");
                var response = await client.PostAsync(uri, stringContent);
                string textResult = await response.Content.ReadAsStringAsync();
                return textResult;
            }
        }
        public static async Task<string> PutAPIAsync(string url, ClienteContactoDto content)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(url);
                var myContent = JsonConvert.SerializeObject(content);
                var stringContent = new StringContent(myContent, UnicodeEncoding.UTF8, "application/json"); 
                var response = await client.PutAsync(uri, stringContent);
                string textResult = await response.Content.ReadAsStringAsync();
                return textResult;
            }
        }
        public static async Task<string> DeleteAPIAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var uri = new Uri(url);
                var response = await client.DeleteAsync(uri);
                string textResult = await response.Content.ReadAsStringAsync();
                return textResult;
            }
        }
    }
}
