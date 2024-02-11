using ConsoleForum.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>

{
    services.AddDbContext<DataContexts>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marku\Documents\Projekt\ConsoleForum\ConsoleForum\Data\database.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"));
}

).Build();