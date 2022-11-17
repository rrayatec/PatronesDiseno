using System.Net.Http.Headers;
namespace APIadapter.Controllers;
class conector
{
    static HttpClient client = new HttpClient();
    public async Task<string> getDataAsync()
    {

        client.BaseAddress = new Uri("http://localhost:5108");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        var products = "";
        try
        {
            HttpResponseMessage response = await client.GetAsync("WeatherForecast");
            if (response.IsSuccessStatusCode)
            {
                products = await response.Content.ReadAsStringAsync();
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return products;
    }
}

