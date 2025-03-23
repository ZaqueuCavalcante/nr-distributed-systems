using Syki.Front.Configs;

var builder = WasmConfigs.CreateHostBuilder(args);

builder.AddMudConfigs();
builder.AddHttpConfigs();

await builder.Build().RunAsync();
