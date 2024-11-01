namespace BlazorLabbv3.Components.Pages
{
	public partial class ExistingUsers
	{
		public List<User>? Users { get; set; }

		protected override async Task OnInitializedAsync()
		{
			UserDataFromApi userData = new UserDataFromApi();
			UserExtensions userEx = new UserExtensions();
			Users = await userData.GetUsersAsync();
			Users = userEx.SortUsersByName(Users);
			Users = userEx.Show5Users(Users);
			await Task.Delay(250);



			// var response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");

			// if (response.IsSuccessStatusCode)
			// {
			//     var data = await response.Content.ReadAsStringAsync();

			//     users = JsonSerializer.Deserialize<List<User>>(data);
			// }

			// Simulate asynchronous loading to demonstrate streaming rendering

		}

	}
}