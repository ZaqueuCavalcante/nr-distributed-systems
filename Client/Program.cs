using Syki.Front.Configs;

var builder = WasmConfigs.CreateHostBuilder(args);

builder.AddMudConfigs();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
