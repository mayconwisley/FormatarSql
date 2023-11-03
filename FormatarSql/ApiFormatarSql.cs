using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace FormatarSql;

public class ApiFormatarSql
{
    private const string? api = @"api/v1/format";

    public static async Task<ResultadoApi> FormatarSql(StringBuilder stringBuilder)
    {
        try
        {
            HttpClient client = new()
            {
                BaseAddress = new Uri("https://sqlformat.org/")
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("sql", stringBuilder.ToString()),
                new KeyValuePair<string, string>("indent_width","4")

            });

            HttpResponseMessage response = await client.PostAsync(api, content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStreamAsync();
                var resultadoApi = await JsonSerializer.DeserializeAsync<ResultadoApi>(responseContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});

                if (resultadoApi is not null)
                {
                    return resultadoApi;
                }
            }
            return new();
        }
        catch (Exception)
        {

            throw;
        }

    }

}

