using Newtonsoft.Json;
using swapi_csharp;

class Program
{
    static async Task Main()
    {
        string swapiUrl = "https://swapi.dev/api/planets/";

        using (var httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(swapiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    var planets = JsonConvert.DeserializeObject<SWAPIResponse<Planet>>(jsonContent);

                    Console.WriteLine("List of Planets from SWAPI:");
                    foreach (var planet in planets.Results)
                    {
                        Console.WriteLine(planet.Name);
                    }
                }
                else
                {
                    Console.WriteLine("Failed to retrieve data from SWAPI.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
