using FinalProjectAPI.Mediator;
using FinalProjectAPI.Models;
using FinalProjectAPI.Singleton;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<EntertainmentItem> listaEntertainment = new List<EntertainmentItem>
    {
        new EntertainmentItem { Id = 1, Tipo = "cancion", Nombre = "Azul", China = false, Infantil = false },
        new EntertainmentItem { Id = 2, Tipo = "audiolibro", Nombre = "El Arte de la Guerra", China = false, Infantil = true },
        new EntertainmentItem { Id = 3, Tipo = "serie", Nombre = "Breaking Bad", China = false, Infantil = false },
        new EntertainmentItem { Id = 4, Tipo = "cancion", Nombre = "There, There", China = true, Infantil = true },
        new EntertainmentItem { Id = 5, Tipo = "audiolibro", Nombre = "Cien Años de Soledad", China = false, Infantil = true },
        new EntertainmentItem { Id = 6, Tipo = "serie", Nombre = "Stranger Things", China = true, Infantil = false },
        new EntertainmentItem { Id = 7, Tipo = "cancion", Nombre = "Selfless", China = false, Infantil = true },
        new EntertainmentItem { Id = 8, Tipo = "audiolibro", Nombre = "Sapiens", China = true, Infantil = false },
        new EntertainmentItem { Id = 9, Tipo = "serie", Nombre = "The Crown", China = false, Infantil = false },
        new EntertainmentItem { Id = 10, Tipo = "cancion", Nombre = "505", China = true, Infantil = true },
        new EntertainmentItem { Id = 11, Tipo = "audiolibro", Nombre = "Matar un Ruiseñor", China = false, Infantil = false },
        new EntertainmentItem { Id = 12, Tipo = "serie", Nombre = "Narcos", China = true, Infantil = true },
        new EntertainmentItem { Id = 13, Tipo = "cancion", Nombre = "Best of You", China = false, Infantil = false },
        new EntertainmentItem { Id = 14, Tipo = "audiolibro", Nombre = "Harry Potter y la Piedra Filosofal", China = true, Infantil = true },
        new EntertainmentItem { Id = 15, Tipo = "serie", Nombre = "La Casa de Papel", China = true, Infantil = true },
        new EntertainmentItem { Id = 16, Tipo = "cancion", Nombre = "Cold Contagious", China = false, Infantil = true },
        new EntertainmentItem { Id = 17, Tipo = "audiolibro", Nombre = "1984", China = true, Infantil = false },
        new EntertainmentItem { Id = 18, Tipo = "serie", Nombre = "The Mandalorian", China = false, Infantil = true },
        new EntertainmentItem { Id = 19, Tipo = "cancion", Nombre = "Sunburn", China = true, Infantil = false },
        new EntertainmentItem { Id = 20, Tipo = "audiolibro", Nombre = "El Alquimista", China = true, Infantil = true }
    };

CatalogSingleton catalog = CatalogSingleton.Instance;
catalog.SetList(listaEntertainment);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
