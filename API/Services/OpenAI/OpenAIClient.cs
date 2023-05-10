using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Services.OpenAI
{
    internal class OpenAIClient
    {
        static async Task Main(string[] args)
        {
            string apiKey = "tu_api_key_aqui";
            string prompt = "¡Hola, OpenAI!";

            string apiUrl = "https://api.openai.com/v1/engines/davinci-codex/completions";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var requestData = new
                {
                    prompt = prompt,
                    max_tokens = 50
                };

                var jsonRequest = JsonSerializer.Serialize(requestData);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(apiUrl, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Procesar la respuesta exitosa
                    dynamic result = JsonSerializer.Deserialize(jsonResponse);
                    string generatedText = result.choices[0].text;

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

