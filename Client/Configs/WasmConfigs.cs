using Client;
using Microsoft.AspNetCore.Components.Web;

namespace Syki.Front.Configs;

public static class WasmConfigs
{
    public static WebAssemblyHostBuilder CreateHostBuilder(string[]? args = null)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");
        return builder;
    }
}
