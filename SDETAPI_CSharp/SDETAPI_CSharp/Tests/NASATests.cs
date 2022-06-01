using RestSharp;

namespace SDETAPI_CSharp.Tests;

//First Pull Request
public class Program
{

    public static void HcgCoreTest()
    {
        string fileName =
            "C:/Users/carlos.martinez/source/repos/SDETAPI_CSharp/SDETAPI_CSharp/Requests/HealthcareGov/Gets/hcgGetRequest.json";
        (string Method, string Url) data = JsonReader.readJsonFile(fileName);

        IRestResponse response = RestCore.CreateRequestWithHeaders(data.Url, data.Method);

        System.Diagnostics.Debug.WriteLine("\nStatus Code: " + response.StatusCode + "\n" +
                          "\nContent: " + response.Content);
    }

    public static void NasaCoreTest()
    {
        string fileName =
            "C:/Users/carlos.martinez/source/repos/SDETAPI_CSharp/SDETAPI_CSharp/Requests/NasaOpenAPI/Gets/nasaGetRequest.json";
        (string Method, string Url) data = JsonReader.readJsonFile(fileName);

        IRestResponse response = RestCore.CreateRequestWithHeaders(data.Url, data.Method);
        if (!string.Equals(response.StatusCode.ToString(), "Ok", StringComparison.OrdinalIgnoreCase))
            System.Diagnostics.Debug.WriteLine("\nError: " + response.ErrorMessage);
        else
        {
            System.Diagnostics.Debug.WriteLine("\nStatus Code: " + response.StatusCode + "\n" +
                              "\nContent: " + response.Content);
        }
    }
}
