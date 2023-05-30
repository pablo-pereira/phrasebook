using Microsoft.Extensions.Configuration;
using Services.OpenAI.Domain.Responses.Chat;
using Services.OpenAI.Domain.Responses.Completions;
using Services.OpenAI.Domain.Responses.Model;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Services.OpenAI
{
    public class OpenAIClient : IOpenAIClient
    {

        private readonly IHttpClientFactory _httpClientFactory;
        public OpenAIClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task GetCompletion(string[] prompts)
        {
            string prompt = "¡Hola, OpenAI!";

            var httpClient = _httpClientFactory.CreateClient();
            using (httpClient)
            {

                var requestData = new
                {
                    prompt = prompt,
                    max_tokens = 50
                };

                var jsonRequest = JsonSerializer.Serialize(requestData);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("");
                
                var jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Procesar la respuesta exitosa
                    var result = JsonSerializer.Deserialize<CompletionsResponse>(jsonResponse);
                    string? generatedText = result?.Choices[0].Text;

                    Console.WriteLine("Texto generado: " + generatedText);
                }
                else
                {
                    // Manejar errores
                    Console.WriteLine("Error al realizar la solicitud: " + jsonResponse);
                }
            }

            Console.ReadLine();
        }
    }
}

