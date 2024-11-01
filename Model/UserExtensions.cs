namespace BlazorLabbv3
{
	public class UserExtensions
	{

		public List<User> SortUsersByName(List<User> users)
		{
			var sortedUsers = users?.OrderBy(user => user.name).ToList();
			return sortedUsers;
		}

		public List<User> Show5Users(List<User> users)
		{
			var show5Users = users.Take(5).ToList();
			return show5Users;
		}
	}
}
