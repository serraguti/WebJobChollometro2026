using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebJobChollometro.Data;
using WebJobChollometro.Repositories;

string connectionString =
    @"Data Source=sqlpaco3430.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=adminsql;Password=Admin123;Encrypt=True;Trust Server Certificate=True";
Console.WriteLine("Bienvenido a nuestros Chollos");
//NECESITAMOS LA INYECCION DE DEPENDENCIAS
var provider = new ServiceCollection()
    .AddTransient<RepositoryChollometro>()
    .AddDbContext<ChollometroContext>
    (options => options.UseSqlServer(connectionString))
    .BuildServiceProvider();
//RECUPERAMOS EL REPOSITORY DE LA INYECCION
RepositoryChollometro repo =
    provider.GetService<RepositoryChollometro>();
Console.WriteLine("Pulse ENTER para comenzar...");
Console.ReadLine();
await repo.PopulateChollosAzureAsync();
Console.WriteLine("Proceso completado correctamente");
