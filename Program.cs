using erp_back_net.Data;
using erp_back_net.Services.Client;
using erp_back_net.Services.ClientOrder;
using erp_back_net.Services.Product;
using erp_back_net.Services.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ErpDbContext>();

builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IClientOrderService, ClientOrderService>();

builder.Services.AddOpenApi();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();