using Services.OpenAI;
using System.Net.Http.Headers;

namespace API
{
    public class Program
    {
        public IConfiguration Configuration { get; }

        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services.AddSingleton<IOpenAIClient, OpenAIClient>();
            builder.Services.AddHttpClient<IOpenAIClient,OpenAIClient> ((httpClient) => {
                httpClient.BaseAddress = new Uri(builder.Configuration[key: "OpenAPI_API_BASE_URL"]);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", builder.Configuration[key: "OpenAPI_API_KEY"]); ;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}