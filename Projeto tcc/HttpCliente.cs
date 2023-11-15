using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "http://172.20.10.9/admin/api.php";
        string authToken = "0f1c0a417cb4a3c4648d38f67d4ff43346ce6ebb0e1ce54e61193808fb236ca3";

        // Example of a GET request to get the version of the API
        string versionResponse = await GetPiHoleData(apiUrl + "?version", authToken);
        Console.WriteLine("Version Response:");
        Console.WriteLine(versionResponse);

        // Example of a GET request to get summary data
        string summaryResponse = await GetPiHoleData(apiUrl + "?summary", authToken);
        Console.WriteLine("\nSummary Response:");
        Console.WriteLine(summaryResponse);

        // Example of a POST request to enable Pi-hole ad blocking
        string enableResponse = await PostPiHoleData(apiUrl + "?enable&auth=" + authToken);
        Console.WriteLine("\nEnable Response:");
        Console.WriteLine(enableResponse);

        // Example of a POST request to disable Pi-hole ad blocking for 10 seconds
        string disableResponse = await PostPiHoleData(apiUrl + "?disable=10&auth=" + authToken);
        Console.WriteLine("\nDisable Response:");
        Console.WriteLine(disableResponse);
    }

    static async Task<string> GetPiHoleData(string url, string authToken)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("User-Agent", "PiHoleApiClient");

            // Add authorization header if needed
            // client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authToken);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }
    }

    static async Task<string> PostPiHoleData(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("User-Agent", "PiHoleApiClient");

            // Add authorization header if needed
            // client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authToken);

            HttpResponseMessage response = await client.PostAsync(url, null);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }
    }
}
