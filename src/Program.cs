using ShopStore.Interfaces;
using ShopStore.Repository;
using  ShopStore.DbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 builder.Services.AddDbContext<DataContext>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
