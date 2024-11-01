namespace BlazorLabbv3
{
	public class UserDataFromApi : IUserData
	{
		// public List<User>? sortedUsers { get; set; }
		public async Task<List<User>> GetUsersAsync()
		{
			var client = new HttpClient();
			return await client.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users") ?? new List<User>();
			// sortedUsers = users?.OrderBy(user => user.name).Take(5).ToList();
		}
	}
}
