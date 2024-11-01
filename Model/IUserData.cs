namespace BlazorLabbv3
{
	public interface IUserData
	{
		public Task<List<User>> GetUsersAsync();
	}
}
