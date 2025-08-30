using Spectre.Console;
using System.Text.Json;

namespace SpectreDemos
{
	public static class Helpers
	{
		public static async Task<string> FetchApiDataAsync(string apiUrl)
		{
			using var httpClient = new HttpClient();

			try
			{
				var response = await httpClient.GetAsync(apiUrl);
				response.EnsureSuccessStatusCode();

				return await response.Content.ReadAsStringAsync();
			}
			catch (Exception ex)
			{
				AnsiConsole.MarkupLine($"[red]Error fetching API data: {ex.Message}[/]");

				return string.Empty;
			}
		}

		private static JsonSerializerOptions jsonOptions = new() { PropertyNameCaseInsensitive = true };

		public static async Task<T> GetTypedApiDataAsync<T>(string apiUrl)
		{
			var jsonResponse = await FetchApiDataAsync(apiUrl);
			T output = JsonSerializer.Deserialize<T>(
				jsonResponse,
				jsonOptions)
				?? throw new NullReferenceException();

			return output;
		}
	}
}