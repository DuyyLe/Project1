using ProjectAlta;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using ProjectAlta.Respository;
using ProjectAlta.DBContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectAltaContext") ?? throw new InvalidOperationException("Connection string 'ProjectAltaContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.ServicesCollection(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IEAdminRespository,AdminRespository>();
builder.Services.AddScoped<IECourseRespository, CourseRespository>();
builder.Services.AddScoped<IEDocumentRespository, DocumentRespository>();
builder.Services.AddScoped<IEAdminAccRespository, AdminAccountRespository>();
builder.Services.AddScoped<IEClassRespository, ClassRespository>();
builder.Services.AddScoped<IEGradeRespository, GradeRespository>();
builder.Services.AddScoped<IEClassCourseRespository, ClassCourseRespository>();
builder.Services.AddScoped<IEPositionRespository, PositionRespository>();


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
