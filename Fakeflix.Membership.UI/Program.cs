using Fakeflix.Common.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<MembershipHttpClient>(client => client.BaseAddress = new Uri("https://localhost:5001/api/"));
builder.Services.AddScoped<IMembershipService, MembershipService>();

await builder.Build().RunAsync();
