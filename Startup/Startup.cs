using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto do Entity Framework com banco de dados em memória
builder.Services.AddDbContext<TaskContext>(options =>
    options.UseInMemoryDatabase("TaskList"));

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();