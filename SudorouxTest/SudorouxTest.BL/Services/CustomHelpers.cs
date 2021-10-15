using SudorouxTest.BL.IServices;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SudorouxTest.BL.Services
{
    public class CustomHelpers : ICustomHelpers
    {
        public async Task<MemoryStream> PostExternalApi<T>(T model,string url)
        {

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json"); ;

            var response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var bytes = Encoding.UTF8.GetBytes(data);
                return new MemoryStream(bytes);
            }
            return new MemoryStream();
        }
    }
}
