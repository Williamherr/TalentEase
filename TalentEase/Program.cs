using Microsoft.EntityFrameworkCore;
using TalenEase.Api.Data;
using TalentEase.Api.Mappings;
using TalentEase.Api.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HRDataDbContext>(options => options
    .UseSqlServer(builder.Configuration.GetConnectionString("HRData")));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:8000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler("/Error");
app.UseHsts();

app.UseCors();
app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
