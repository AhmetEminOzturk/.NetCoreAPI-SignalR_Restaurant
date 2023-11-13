using Microsoft.AspNetCore.SignalR;
using Restaurant.Infrastructure.Persistence.Context;

namespace Restaurant.Presentation.WebAPI.Hubs
{
	public class SignalRHub: Hub
	{
		RestaurantDbContext context = new();
		public async Task SendCategoryCount()
		{
			var value = context.Categories.Count();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);
		}
	}
}
