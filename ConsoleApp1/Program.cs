using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;

IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
Console.WriteLine(userService.Delete(7).Result);
