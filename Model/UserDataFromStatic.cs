namespace BlazorLabbv3
{
	public class UserDataFromStatic : IUserData
	{
		public async Task<List<User>> GetUsersAsync()
		{
			var users = Task.Run(GetUsers);
			return await users;
		}
		private List<User> GetUsers()
		{
			var users = new List<User>();
			users.Add(
			new User
			{
				id = 1,
				name = "Lukas Malki",
				username = "lukii2003",
				email = "lukas@iths.se",
				address = new Address
				{
					street = "Småbrukets backe",
					suite = "5 star suite",
					city = "Huddinge",
					zipcode = "141 58",
					geo = new Geo
					{
						lat = 12317.341,
						lng = -834278.4
					}
				},
				phone = "07070707070",
				website = "blazorlabb.com",
				company = new Company
				{
					name = "blazorExpert",
					catchPhrase = "expert in blaazor",
					bs = "blazor king"
				}

			});
			return users;
		}
	}
}
