using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TFG3.Controllers
{
    public class GeminiController
    {
        private string apiKey = "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";
        private static readonly HttpClient client = new HttpClient();

        public async Task<string> PreguntarAsync(string contexto, string pregunta)
        {
            try
            {
                var requestBody = new
                {
                    model = "llama-3.1-8b-instant",
                    messages = new[]
                    {
                        new { role = "system", content = contexto },
                        new { role = "user",   content = pregunta }
                    }
                };

                string json = JsonSerializer.Serialize(requestBody);
                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.groq.com/openai/v1/chat/completions");
                request.Headers.Add("Authorization", "Bearer " + apiKey);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();

                using JsonDocument doc = JsonDocument.Parse(responseBody);
                string respuesta = doc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

                return respuesta ?? "Sin respuesta.";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}