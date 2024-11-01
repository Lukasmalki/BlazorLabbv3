namespace BlazorLabbv3
{
	public class UserDataFromApi : IUserData
	{
		public async Task<List<User>> GetUsersAsync()
		{
			var client = new HttpClient();
			var result = await client.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users") ?? new List<User>();
			return result;
		}
	}
}
