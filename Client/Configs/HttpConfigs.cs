namespace Syki.Front.Configs;

public static class HttpConfigs
{
    public static void AddHttpConfigs(this WebAssemblyHostBuilder builder)
    {
        var apiUrl = builder.Configuration.GetSection("ApiUrl").Value!;

        builder.Services
            .AddHttpClient("HttpClient", x => x.BaseAddress = new Uri(apiUrl));

        builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>()
            .CreateClient("HttpClient"));
    }
}
